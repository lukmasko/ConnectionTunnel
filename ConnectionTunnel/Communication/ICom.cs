using System;

namespace ConnectionTunnel.Communication
{
   internal interface ICom
   {
      int read();

      void write(int b);

      void run();

      void stop();
   }
}
