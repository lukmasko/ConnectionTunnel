using ConnectionTunnel.Settings;
using System.Windows.Forms;
using System;

namespace ConnectionTunnel
{
   public partial class SettingsForm : Form
   {
      private SettingsManager settingsManager;

      public SettingsForm()
      {
         InitializeComponent();

         settingsManager = SettingsManager.GetInstance();
         settingsManager.Load();

         pluginCom1.LoadSettings(settingsManager.Settings.com1);
         pluginCom2.LoadSettings(settingsManager.Settings.com2);
      }

      private void saveSettingsButton_Click(object sender, EventArgs e)
      {
         settingsManager.Settings.com1 = pluginCom1.GetSettings();
         settingsManager.Settings.com2 = pluginCom2.GetSettings();

         settingsManager.Save();
         this.Close();
      }

      private void cancelSettingsButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
