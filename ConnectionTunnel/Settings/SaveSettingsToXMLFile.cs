using ConnectionTunnel.Settings;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ConnectionTunnel.SettingsManagement
{
   public class SaveSettingsToXMLFile : ISettingsPersistance
   {
      private static string fileName = "settings.conf";

      public void Save(TunnelSettings settings)
      {
         try
         {
            using (var writer = new System.IO.StringWriter())
            {
               var serializer = new XmlSerializer(typeof(TunnelSettings));
               serializer.Serialize(writer, settings);
               File.WriteAllText(fileName, writer.ToString());
               writer.Close();
            }
         }
         catch (Exception) { }
      }

      public TunnelSettings Load()
      {
         try
         {
            var serializer = new XmlSerializer(typeof(TunnelSettings));
            using (TextReader reader = new StringReader(File.ReadAllText(fileName)))
            {
               return (TunnelSettings)serializer.Deserialize(reader);
            }
         }
         catch (Exception) { }

         return new TunnelSettings();
      }

   }
}
