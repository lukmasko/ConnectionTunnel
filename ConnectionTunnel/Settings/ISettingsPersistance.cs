using ConnectionTunnel.Settings;

namespace ConnectionTunnel.SettingsManagement
{
   interface ISettingsPersistance
   {
      void Save(TunnelSettings settings);
      TunnelSettings Load();
   }
}
