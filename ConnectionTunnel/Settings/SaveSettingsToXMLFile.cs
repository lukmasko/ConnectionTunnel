using ConnectionTunnel.Settings;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ConnectionTunnel.SettingsManagement
{
   public class SaveSettingsToXMLFile : ISettingsPersistance
   {
      private static string fileName = "settings.conf";

      public SaveSettingsToXMLFile()
      {
      }

      public void Save(TunnelSettings settings)
      {
         string xmlSettings = string.Empty;

         try
         {
            using (var stringwriter = new System.IO.StringWriter())
            {
               var serializer = new XmlSerializer(typeof(TunnelSettings));
               serializer.Serialize(stringwriter, settings);
               File.WriteAllText(fileName, stringwriter.ToString());
            }
         }
         catch (Exception) { }
      }

      public TunnelSettings Load()
      {
         try
         {
            var serializerForInternal = new XmlSerializer(typeof(TunnelSettings));
            using (TextReader reader = new StringReader(File.ReadAllText(fileName)))
            {
               return (TunnelSettings)serializerForInternal.Deserialize(reader);
            }
         }
         catch (Exception) { }

         return new TunnelSettings();
      }

   }
}
