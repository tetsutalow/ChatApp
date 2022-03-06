using ChatAppCommon;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        private TcpClientEx Client { get; set; }

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // クライアントを閉じる
            if(Client != null)
            {
                Client.Client.Close();
                Client.Client.Dispose();
                Client = null;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var destPort = txtDestPort.Text.Trim();
            var sourcePort = txtSourcePort.Text.Trim();
            var ipAddress = txtAddress.Text.Trim();

            try
            {
                // 接続情報有効チェック
                if (!CheckConnectionSettings(destPort, sourcePort, ipAddress)) return;

                // 接続先IPEndPoint作成
                var remoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAddress), int.Parse(destPort));

                // 接続元IPEndPoint作成
                var localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(sourcePort));

                // クライアント作成
                Client = new TcpClientEx(localEndPoint);

                // サーバーに接続
                Client.Client.Connect(remoteEndPoint);

                // 接続ログ出力
                SetLog("サーバーに接続しました。");

                // データ受信待機開始
                var data = new CommunicationData(Client);
                Client.Socket.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);

                // ボタンの有効状態を設定
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                // 接続ログ出力
                SetLog("サーバーに接続できませんでした。");
            }
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            try
            {
                // ユーザー定義型のオブジェクト取得
                var data = result.AsyncState as CommunicationData;

                // 切断をクリックしている場合
                if (data.Client.Socket == null) return;

                // サーバーからのデータを受信
                data.Client.Socket?.EndReceive(result);

                // 受信データを出力
                SetLog($"サーバーからデータ受信<<{data}");

                // 再度サーバーからのデータ受信を待機
                data.Client.Socket.BeginReceive(data.Data, 0, data.Data.Length, SocketFlags.None, ReceiveCallback, data);
            }
            catch (Exception) 
            {
                // 切断ログ出力
                SetLog("サーバーから切断されました。");

                // ボタンの有効状態を設定
                Invoke(new Action(() => 
                {
                    btnStart.Enabled = true;
                    btnEnd.Enabled = false;
                    btnSend.Enabled = false;
                }));
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // クライアントを閉じる
            Client.Client.Close();
            Client.Client.Dispose();
            Client = null;

            // 切断ログ出力
            SetLog("サーバーから切断しました。");

            // ボタンの有効状態を設定
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            btnSend.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // 送信データを作成
                var data = Encoding.UTF8.GetBytes(txtName.Text + "：" + txtMessage.Text);

                // サーバーにデータを送信
                Client?.Socket.Send(data);

                // 送信ログ出力
                SetLog($"サーバーにデータ送信>>{Encoding.UTF8.GetString(data)}");
            }
            catch (Exception)
            {
                SetLog("データ送信に失敗しました。");
            }
        }

        private void SetLog(string text)
        {
            Invoke(new Action(() =>
            {
                // ログを追加
                lbLog.Items.Add($"{DateTime.Now.ToString("HH:mm:ss.ff")}：{text}");

                // リスト末尾を選択中とする
                lbLog.SelectedIndex = lbLog.Items.Count != -1 ? lbLog.Items.Count - 1 : -1;
            }));
        }

        private bool CheckConnectionSettings(string destPort, string sourcePort, string ipAddress)
        {
            // ポート番号空チェック
            if (string.IsNullOrEmpty(destPort) || string.IsNullOrEmpty(sourcePort))
            {
                MessageBox.Show("ポート番号が空です。");
                return false;
            }

            // ポート番号数値チェック
            if (!Regex.IsMatch(destPort, "^[0-9]+$") || !Regex.IsMatch(sourcePort, "^[0-9]+$"))
            {
                MessageBox.Show("ポート番号は数値を指定してください。");
                return false;
            }

            var destPortNum = int.Parse(destPort);
            var sourcePortNum = int.Parse(sourcePort);

            // ポート番号有効値チェック
            if (destPortNum < IPEndPoint.MinPort || IPEndPoint.MaxPort < destPortNum ||
                sourcePortNum < IPEndPoint.MinPort || IPEndPoint.MaxPort < sourcePortNum)
            {
                MessageBox.Show("無効なポート番号が指定されています。");
                return false;
            }

            // IPアドレス有効チェック
            if (!IPAddress.TryParse(ipAddress, out IPAddress _))
            {
                MessageBox.Show("無効なIPアドレスが指定されています。");
                return false;
            }

            return true;
        }
    }
}
