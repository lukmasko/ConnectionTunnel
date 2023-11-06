using ConnectionTunnel.Communication;
using ConnectionTunnel.Settings;
using System.Threading;

namespace ConnectionTunnel
{
   internal class TunnelManager
   {
      private ICom com1;
      private ICom com2;

      private Thread h_thread;
      private ComThreadState h_threadState;
      private SettingsManager settingsManager;

      public TunnelManager()
      {
         settingsManager = SettingsManager.GetInstance();
         h_threadState = ComThreadState.Stopped;
      }

      private void thread()
      {
         com1.run();
         com2.run();

         h_threadState = ComThreadState.Running;
         int b;

         do
         {
            while((b = com2.read()) > 0){
               com1.write(b);
            }
            while ((b = com1.read()) > 0) {
               com2.write(b);
            }

            if (h_threadState != ComThreadState.Running)
               break;

            Thread.Sleep(1);
         }
         while (true);

         com1.stop();
         com2.stop();

         h_threadState = ComThreadState.Stopped;
      }

      public void Run()
      {
         com1 = ComFactory.CreateCom(settingsManager.Settings.com1);
         com2 = ComFactory.CreateCom(settingsManager.Settings.com2);

         h_thread = new Thread(new ThreadStart(thread));
         h_thread.Start();
      }

      public void Stop()
      {
         if (h_threadState == ComThreadState.Stopped)
            return;

         h_threadState = ComThreadState.TryStop;
      }

      public bool IsRunning()
      {
         return (h_threadState == ComThreadState.Stopped) ? false : true;
      }
   }
}
