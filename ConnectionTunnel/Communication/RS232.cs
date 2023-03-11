using System.IO.Ports;

namespace ConnectionTunnel.Communication
{
   internal class RS232 : ICom
   {
      private SerialPort com;

      public void write(int b)
      {
         if (b <= 0)
            return;
         com.Write(new byte[] { (byte)b }, 0, 1);
      }

      public int read()
      {
         if (com.BytesToRead <= 0)
            return 0;
         return com.ReadByte();
      }

      public static RS232 Create(string comName, int baudRate)
      {
         return new RS232(comName, baudRate);
      }

      public void run()
      {
         com.Open();
         com.DiscardInBuffer();
         com.DiscardOutBuffer();
      }

      public void stop()
      {
         com.Close();
      }

      private RS232() { }

      private RS232(string comName, int baudRate)
      {
         com = new SerialPort(comName, baudRate);
      }
   }
}
