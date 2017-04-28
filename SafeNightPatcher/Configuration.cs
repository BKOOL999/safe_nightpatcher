using System;
using System.IO;
using System.Xml.Serialization;

namespace SafeNightPatcher
{
    [Serializable]
    public class Configuration
    {
        public String lastIp;

        private static XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
        public static Configuration currentConfig;
    
        public static void Load()
        {
            if (!File.Exists("Nightpatcherconfig.xml"))
            {
                currentConfig = new Configuration();
                currentConfig.lastIp = "";

                Save();
            }
            else
            {
                using (FileStream stream = File.OpenRead("Nightpatcherconfig.xml"))
                {
                    currentConfig = (Configuration)serializer.Deserialize(stream);
                }
            }
        }

        public static void Save()
        {
            File.Delete("Nightpatcherconfig.xml");
            using (FileStream writer = File.OpenWrite("Nightpatcherconfig.xml"))
            {
                serializer.Serialize(writer, currentConfig);
            }
        }

    }
}
