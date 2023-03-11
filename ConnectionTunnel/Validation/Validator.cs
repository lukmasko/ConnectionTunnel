using System;
using System.Net;

namespace ConnectionTunnel.Validation
{
   internal class Validator
   {

      public static string GetIP(string value, string defValue)
      {
         IPAddress ip;
         return (IPAddress.TryParse(value, out ip)) ? value : defValue;
      }

      public static int GetPort(int val, int defVal)
      {
         try {
            int port = Convert.ToInt32(val);
            if(port > 0 && port < 65536)
               return port;
         }
         catch (Exception) { }
         return defVal;
      }

      public static int GetRS232BaudRate(int value, int []def)
      {
         int idx = Array.IndexOf(def, value);
         return (idx > -1) ? value : def[0];
      }

      public static int GetConnectionType(int value, string []def)
      {
         if (value < 0 || value > def.Length)
            return 0;
         return value;
      }

      internal static string GetRS232ComName(string value, string def)
      {
         if (value != null && value.Length > 3 && value.Substring(0, 3).CompareTo("COM") == 0 && int.TryParse(value.Substring(3, value.Length - 3), out int o)) {
            return value;
         }
         return def;
      }
   }
}
