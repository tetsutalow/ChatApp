using ChatAppCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    public partial class ServerForm : Form
    {
        /// <summary>
        /// TCPサーバー。
        /// </summary>
        private TcpListenerEx Server { get; set; }

        /// <summary>
        /// 接続中クライアントリスト。
        /// </summary>
        private SynchronizedCollection<TcpClientEx> ClientList { get; set; }

        public ServerForm()
        {
            InitializeComponent();

            ClientList = new SynchronizedCollection<TcpClientEx>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 接続状態設定
            SetConnectionStatus(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var port = txtPort.Text.Trim();

            try
            {
                // 接続情報有効チェック
                if (!CheckConnectionSettings(port)) return;

                // サーバーを作成して監視開始
                var localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(port));
                Server = new TcpListenerEx(localEndPoint);
                Server.Start();

                // 接続受付ループ開始
                _ = AcceptWaitLoop();

                // 接続状態設定
                SetConnectionStatus(true);

                // ボタンの有効状態を設定
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
            }
            catch(SocketException ex) when (ex.SocketErrorCode == SocketError.AddressAlreadyInUse)
            {
                MessageBox.Show("指定のポートは他のシステムに使用されています。");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // サーバー停止
            Server?.Stop();
            Server = null;

            // 接続状態設定
            SetConnectionStatus(false);

            // 接続中クライアントリストをクリア
            lbConnectingClient.Items.Clear();

            // 接続中クライアントを全て閉じる
            lock (ClientList.SyncRoot)
            {
                foreach (var client in ClientList)
                {
                    client.Socket.Close();
                }
                ClientList.Clear();
            }

            // ボタンの有効状態を設定
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }

        private bool CheckConnectionSettings(string port)
        {
            // ポート番号空チェック
            if (string.IsNullOrEmpty(port))
            {
                MessageBox.Show("ポート番号が空です。");
                return false;
            }

            // ポート番号数値チェック
            if (!Regex.IsMatch(port, "^[0-9]+$"))
            {
                MessageBox.Show("ポート番号は数値を指定してください。");
                return false;
            }

            var portNum = int.Parse(port);

            // ポート番号有効値チェック
            if (portNum < IPEndPoint.MinPort || IPEndPoint.MaxPort < portNum)
            {
                MessageBox.Show("無効なポート番号が指定されています。");
                return false;
            }

            return true;
        }

        private void SetConnectionStatus(bool connection)
        {
            // 状態設定
            Invoke(new Action(() => sslblStatus.Text = $"状態：{(connection ? "監視中" : "停止")}"));
        }

        private void SetConnectiongClient(TcpClient client, bool add)
        {
            Invoke(new Action(() =>
            {
                if (add)
                {
                    // 接続中クライアント追加
                    lbConnectingClient.Items.Add(client.Client.RemoteEndPoint);
                }
                else
                {
                    // 接続中クライアント削除
                    lbConnectingClient.Items.Remove(client.Client.RemoteEndPoint);
                }

                // リスト末尾を選択中とする
                lbConnectingClient.SelectedIndex = lbConnectingClient.Items.Count != -1 ? lbConnectingClient.Items.Count - 1 : -1;
            }));
        }

        private void AddLog(string text)
        {
            Invoke(new Action(() => 
            {
                // ログを追加
                lbLog.Items.Add($"{DateTime.Now.ToString("HH:mm:ss.ff")}：{text}");

                // リスト末尾を選択中とする
                lbLog.SelectedIndex = lbLog.Items.Count != -1 ? lbLog.Items.Count - 1 : -1;
            }));
        }

        private async Task AcceptWaitLoop()
        {
            AddLog("接続受け入れ開始。");

            await Task.Run(() =>
            {
                // サーバーが監視中の間は接続を受け入れ続ける
                while (Server != null && Server.Active)
                {
                    try
                    {
                        // 非同期で接続を待ち受ける
                        Server.BeginAcceptTcpClient(AcceptCallback, null).AsyncWaitHandle.WaitOne(-1);
                    }
                    catch (Exception)
                    {
                        AddLog("接続受け入れでエラーが発生しました。");
                        break;
                    }
                }
            });

            AddLog("接続受け入れ終了。");
        }

        private void AcceptCallback(IAsyncResult result)
        {
            try
            {
                // 接続を受け入れる
                var client = Server.EndAcceptTcpClient(result);

                // 接続ログを出力
                AddLog($"{client.Client.RemoteEndPoint}からの接続");

                // 接続中クライアントを追加
                var clientInfo = new TcpClientEx(client);
                SetConnectiongClient(client, true);
                ClientList.Add(clientInfo);

                // クライアントからのデータ受信を待機
                var data = new CommunicationData(clientInfo);
                client.Client.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);

                // 接続中クライアント(接続したクライアント以外)に対してクライアントが接続した情報を送信する
                SendDataToAllClient(data, $"{data.Client.RemoteEndPoint}がサーバーに接続しました。");
            }
            catch (Exception) { }
        }

        private void SendDataToAllClient(CommunicationData data, string text) 
        {
            lock (ClientList.SyncRoot)
            {
                foreach (var client in ClientList.Where(e => !e.Equals(data.Client)))
                {
                    // データ送信
                    client.Socket.Send(Encoding.UTF8.GetBytes(text));

                    // 送信ログを出力
                    AddLog($"{client.RemoteEndPoint}にデータ送信>>{text}");
                }
            }
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            try
            {
                // クライアントからのデータを受信
                var data = result.AsyncState as CommunicationData;
                var length = data.Client.Socket.EndReceive(result);

                // 受信データが0byteの場合切断と判定
                if (length == 0)
                {
                    // 切断ログを出力
                    AddLog($"{data.Client.RemoteEndPoint}からの切断");

                    // 接続中クライアントを削除
                    SetConnectiongClient(data.Client.Client, false);
                    ClientList.Remove(data.Client);

                    // 接続中クライアント(切断したクライアント以外)に対してクライアントが切断した情報を送信する
                    SendDataToAllClient(data, $"{data.Client.RemoteEndPoint}がサーバーから切断しました。");

                    // データ受信を終了
                    return;
                }

                // 受信データを出力
                AddLog($"{data.Client.RemoteEndPoint}からデータ受信<<{data}");

                // 接続中クライアント(送信したクライアント以外)に対して受信したデータを送信する
                SendDataToAllClient(data, data.ToString());

                // サーバーが監視中の場合
                if (Server != null && Server.Active)
                {
                    // 再度クライアントからのデータ受信を待機
                    data.Client.Socket.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);
                }
            }
            catch (Exception) { }
        }
    }
}
