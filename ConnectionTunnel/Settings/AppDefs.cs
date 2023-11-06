
namespace ConnectionTunnel.Settings
{
   internal class AppDefs
   {
      public static readonly string[] COM_TYPES = new string[] { "RS232", "USB", "TCP/IP Server", "TCP/IP Client", "WebSocket Server", "WebSocket Client" };
      public static readonly int[] COM_BAUDRATE = new int[] { 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 57600, 115200 };

      public static readonly int DEFAULT_CONNECTION_TYPE = 0;
      public static readonly string DEFAULT_IP = "127.0.0.1";
      public static readonly int TCP_SERVER_DEFAULT_PORT = 6001;
   }
}
