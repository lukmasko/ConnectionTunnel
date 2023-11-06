using ConnectionTunnel.SettingsManagement;

namespace ConnectionTunnel.Settings
{
   internal class SettingsManager
   {
      private static SettingsManager instance = null;
      private ISettingsPersistance saver = null;
      public TunnelSettings Settings;

      public static SettingsManager GetInstance()
      {
         if (instance == null)
            instance = new SettingsManager();
         return instance;
      }

      public void Init(ISettingsPersistance _saver)
      {
         if (saver == null)
            saver = _saver;
      }

      public void Save()
      {
         saver.Save(Settings);
      }

      public void Load()
      {
         Settings = saver.Load();
      }

      private SettingsManager() { }
   }

   
}
