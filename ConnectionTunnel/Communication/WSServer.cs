using System.Text;
using System;

namespace ConnectionTunnel.Communication
{
   internal class WSServer : ICom
   {
      private int port;

      public static WSServer Create(int _port)
      {
         return new WSServer(_port);
      }

      public int read()
      {
         return 0;
      }

      public void run()
      {
         //server.Start();
      }

      public void stop()
      {
         //server.Stop();
      }

      public void write(int b)
      {
         
      }

      private WSServer(int _port)
      {
         port = _port;
      }

      private WSServer() { }
   }
}
