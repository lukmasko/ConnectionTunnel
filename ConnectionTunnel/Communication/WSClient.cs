using System;

namespace ConnectionTunnel.Communication
{
   internal class WSClient : ICom
   {
      internal static ICom Create(string webSocketClientIP, int webSocketClientPort)
      {
         throw new NotImplementedException();
      }

      public int read()
      {
         throw new NotImplementedException();
      }

      public void run()
      {
         throw new NotImplementedException();
      }

      public void stop()
      {
         throw new NotImplementedException();
      }

      public void write(int b)
      {
         throw new NotImplementedException();
      }
   }
}
