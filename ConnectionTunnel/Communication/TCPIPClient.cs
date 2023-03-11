using System.Net.Sockets;

namespace ConnectionTunnel.Communication
{
   internal class TCPIPClient : ICom
   {
      private string ip;
      private int port;
      private TcpClient client;
      private NetworkStream netStream;

      public static TCPIPClient Create(string _ip, int _port)
      {
         return new TCPIPClient(_ip, _port);
      }

      public int read()
      {
         if (!netStream.DataAvailable)
            return 0;
         return netStream.ReadByte();
      }

      public void run()
      {
         client = new TcpClient(ip, port);
         netStream = client.GetStream();
      }

      public void stop()
      {
         client.Close();
      }

      public void write(int b)
      {
         if (b <= 0)
            return;
         netStream.Write(new byte[] { (byte)b }, 0, 1);
      }

      private TCPIPClient(string _ip, int _port)
      {
         ip = _ip;
         port = _port;
      }

      private TCPIPClient() { }
   }
}
