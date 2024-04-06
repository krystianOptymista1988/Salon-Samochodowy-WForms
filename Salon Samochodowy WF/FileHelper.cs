using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Salon_Samochodowy_WF
{
    public class FileHelper
    {
        public static string _filePath = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\Cars.txt";
        
        public static int? FirstCheck()
        {
            int? index = 0;
            if (!File.Exists(_filePath))
                return index;
            else
            {
                var list = DeserializeFromFile();
                index = list.OrderByDescending(x => x.Id).FirstOrDefault().Id;
                return index;
            }
        }
        public static List<Car> DeserializeFromFile()
        {
            List<Car> list = new List<Car>();
            

            if (!File.Exists(_filePath))
            {
                list = new List<Car>();
             
                MessageBox.Show("Twoja lista jest na razie pusta :)");
                return list;
            }

            var serializer = new XmlSerializer(typeof(List<Car>));
            using (var streamReader = new StreamReader(_filePath))
            {
                list = (List<Car>)serializer.Deserialize(streamReader);
                streamReader.Close();
                return list;

            }
        }
        public static void SerializeToFile(List<Car> list)
        {
            var serializer = new XmlSerializer(typeof(List<Car>));
            using (var streamWriter = new StreamWriter(_filePath))
            {
                serializer.Serialize(streamWriter, list);
                streamWriter.Close();
            }
        }
    }
}
