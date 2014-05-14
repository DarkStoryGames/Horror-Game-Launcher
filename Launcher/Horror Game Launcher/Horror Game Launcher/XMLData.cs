using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Horror_Game_Launcher
{
    public class XMLSave
    {
        public static void SaveData(object IClass, string filename)
        {
            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer((IClass.GetType()));
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, IClass);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
        }
    }

    public class XMLLoad<T>
    {
        public static Type type;

        public XMLLoad()
        {
            type = typeof(T);
        }

        public T LoadData(String filename)
        {
            T result;

            XmlSerializer xmlSerializer = new XmlSerializer(type);
            try
            {
                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                result = (T)xmlSerializer.Deserialize(fs);
                fs.Close();
                return (T)result;
            }
            catch
            {

            }

            return default(T);
        }
        public static bool fileExists(String filename)
        {
            if(File.Exists(filename))
                return true;
            else
                return false;
        }
    }
}
