using ConnectionTunnel.Settings;
using ConnectionTunnel.SettingsManagement;
using System;
using System.Windows.Forms;

namespace ConnectionTunnel
{
   public partial class Form1 : Form
   {
      private TunnelManager tunnelManager;
      private SettingsManager settingsManager;

      public Form1()
      {
         InitializeComponent();

         tunnelManager = new TunnelManager();

         settingsManager = SettingsManager.GetInstance();
         settingsManager.Init(new SaveSettingsToXMLFile());
         settingsManager.Load();
      }

      private void settingsButton_Click(object sender, EventArgs e)
      {
         var form = new SettingsForm();
         form.ShowDialog();
      }

      private void playButton_Click(object sender, EventArgs e)
      {
         if (tunnelManager.IsRunning())
            return;

         playButton.Enabled = false;
         stopButton.Enabled = true;
         settingsButton.Enabled = false;

         tunnelManager.Run();
      }

      private void stopButton_Click(object sender, EventArgs e)
      {
         tunnelManager.Stop();

         playButton.Enabled = true;
         stopButton.Enabled = false;
         settingsButton.Enabled = true;
      }

      private void logsButton_Click(object sender, EventArgs e)
      {
         // open log folder...
         // todo
      }

      private void FormClosedEvent(object sender, FormClosedEventArgs e)
      {
         tunnelManager.Stop();
         while (tunnelManager.IsRunning());
      }

      private void FormClosingEvent(object sender, FormClosingEventArgs e)
      {
         //e.Cancel = true;
      }

      private void MinimizeToTray()
      {
         notifyIcon1.Visible = true;
         Hide();
      }
      private void MaximizeFromTray()
      {

      }
   }
}
