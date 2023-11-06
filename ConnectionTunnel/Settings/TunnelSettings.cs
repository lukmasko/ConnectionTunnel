using ConnectionTunnel.Validation;

namespace ConnectionTunnel.Settings
{
   public struct ComSettings
   {
      private int connectionType;
      public int ConnectionType
      {
         get { return connectionType; }
         set { connectionType = Validator.GetConnectionType(value, AppDefs.COM_TYPES); }
      }

      private string rs232ComName;
      public string RS232ComName
      {
         get { return rs232ComName; }
         set { rs232ComName = Validator.GetRS232ComName(value, "COM1"); }
      }

      private int rs232BaudRate;
      public int RS232BaudRate
      {
         set { rs232BaudRate = Validator.GetRS232BaudRate(value, AppDefs.COM_BAUDRATE); }
         get { return rs232BaudRate; }
      }

      private int tcpServerPort;
      public int TCPServerPort
      {
         get { return tcpServerPort; }
         set { tcpServerPort = Validator.GetPort(value, AppDefs.TCP_SERVER_DEFAULT_PORT); }
      }

      private string tcpClientIP;
      public string TCPClientIP
      {
         get { return tcpClientIP; }
         set { tcpClientIP = Validator.GetIP(value, AppDefs.DEFAULT_IP); }
      }

      private int tcpClientPort;
      public int TCPClientPort
      {
         get { return tcpClientPort; }
         set { tcpClientPort = Validator.GetPort(value, AppDefs.TCP_SERVER_DEFAULT_PORT); }
      }

      private string usbComName;
      public string USBComName
      {
         get { return usbComName; }
         set { usbComName = value; }
      }

      private int websocketServerPort;
      public int WebSocketServerPort
      {
         get { return websocketServerPort; }
         set { websocketServerPort = Validator.GetPort(value, AppDefs.TCP_SERVER_DEFAULT_PORT); }
      }

      private string websocketClientIP;
      public string WebSocketClientIP
      {
         get { return websocketClientIP; }
         set { websocketClientIP = Validator.GetIP(value, AppDefs.DEFAULT_IP); }
      }

      private int websocketClientPort;
      public int WebSocketClientPort
      {
         get { return websocketClientPort; }
         set { websocketClientPort = Validator.GetPort(value, AppDefs.TCP_SERVER_DEFAULT_PORT); }
      }
   }

   public struct TunnelSettings
   {
      public ComSettings com1;
      public ComSettings com2;
   }

}
