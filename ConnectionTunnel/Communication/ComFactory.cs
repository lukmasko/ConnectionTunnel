using ConnectionTunnel.Settings;

namespace ConnectionTunnel.Communication
{
   internal class ComFactory
   {
      public static ICom CreateCom(ComSettings settings)
      {
         switch(settings.ConnectionType)
         {
            case 0: 
               return RS232.Create(settings.RS232ComName, settings.RS232BaudRate);

            case 1:
               return RS232.Create(settings.USBComName, 0);

            case 2:
               return TCPIPServer.Create(settings.TCPServerPort);

            case 3:
               return TCPIPClient.Create(settings.TCPClientIP, settings.TCPClientPort);

            case 4:
               return WSServer.Create(settings.WebSocketServerPort);

            case 5:
               return WSClient.Create(settings.WebSocketClientIP, settings.WebSocketClientPort);
         }

         return RS232.Create(settings.RS232ComName, settings.RS232BaudRate);
      }


      private ComFactory() { }
   }
}
