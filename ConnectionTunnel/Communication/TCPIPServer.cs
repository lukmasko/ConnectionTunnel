using System.Net.Sockets;

namespace ConnectionTunnel.Communication
{
   internal class TCPIPServer : ICom
   {
      private int port;
      private TcpListener server;
      private TcpClient client;
      private NetworkStream netStream;

      public static TCPIPServer Create(int _port)
      {
         return new TCPIPServer(_port);
      }

      public void run()
      {
         server = new TcpListener(port);
         server.Start();
         client = server.AcceptTcpClient();
         netStream = client.GetStream();
      }

      public void stop()
      {
         server.Stop();
      }

      public void write(int b)
      {
         if (b <= 0)
            return;
         netStream.Write(new byte[] { (byte)b }, 0, 1);
      }

      public int read()
      {
         if (!netStream.DataAvailable)
            return 0;
         return netStream.ReadByte();
      }

      private TCPIPServer(int _port)
      {
         port = _port;
      }

      private TCPIPServer() { }
   }
}
