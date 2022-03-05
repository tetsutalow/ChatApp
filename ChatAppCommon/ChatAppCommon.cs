using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatAppCommon
{
    /// <summary>
    /// 通信データクラス。
    /// </summary>
    public class CommunicationData
    {
        /// <summary>
        /// 通信データサイズ最大値
        /// </summary>
        const int MAX_COMMUNICATION_DATA_SIZE = 5120;

        /// <summary>
        /// 通信データバッファ。
        /// </summary>
        public byte[] Data = new byte[MAX_COMMUNICATION_DATA_SIZE];

        /// <summary>
        /// 通信クライアント。
        /// </summary>
        public TcpClientEx Client { get; private set; }

        public CommunicationData(TcpClientEx info)
        {
            Client = info;
        }

        /// <summary>
        /// 通信データをUTF8でエンコーディングした文字列を取得する。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Encoding.UTF8.GetString(Data);
        }
    }

    /// <summary>
    /// Activeプロパティを外部から参照できる様にしたTcpListener拡張クラス。
    /// </summary>
    public class TcpListenerEx : TcpListener
    {
        /// <summary>
        //  System.Net.Sockets.TcpListener がクライアント接続をアクティブに待機しているかどうかを示す値を取得します。
        //  System.Net.Sockets.TcpListener がアクティブに待機している場合は true。それ以外の場合は false。
        /// </summary>
        public new bool Active => base.Active;

        public TcpListenerEx(IPEndPoint ep) : base(ep) { }
    }

    /// <summary>
    /// 接続中クライアントクラス。
    /// TcpClientのSocketプロパティへのアクセスが面倒なのでアクセスを省略するための拡張クラス。
    /// </summary>
    public class TcpClientEx
    {
        public EndPoint RemoteEndPoint => Socket.RemoteEndPoint;

        public TcpClient Client { get; private set; }

        public Socket Socket => Client.Client;

        public TcpClientEx(TcpClient client)
        {
            Client = client;
        }

        public TcpClientEx(IPEndPoint ep)
        {
            Client = new TcpClient(ep);
        }
    }
}
