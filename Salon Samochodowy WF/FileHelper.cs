using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
        public static string _carsPath = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\Cars\";

        public static void FolderCheck()
        {
         if (!Directory.Exists(FileHelper._carsPath))
            {
                Directory.CreateDirectory(FileHelper._carsPath);
            }
        }
        public static void FileAdding(Car selectedObject)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    var imageExtensions = string.Join(";", ImageCodecInfo.GetImageDecoders().Select(ici => ici.FilenameExtension));
                    openFileDialog.Filter = string.Format("Images|{0}|All Files|*.*", imageExtensions);
                    var fileName = openFileDialog.FileName;
                    try
                    {
                        var fileCheck = $@"{FileHelper._carsPath}\{selectedObject.Id}.jpg";
                        if (File.Exists(fileCheck))
                         File.Delete(fileCheck); 

                        File.Copy(fileName, $@"{FileHelper._carsPath}\{selectedObject.Id}.jpg");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"COŚ POSZŁO NIE TAK !!! sprawdź uprawnienia programu" + ex);
                    }
                    selectedObject.Picturelocalization = $@"{FileHelper._carsPath}\{selectedObject.Id}.jpg";
                    FileHelper.SerializeToFile(Main.list);
                    MessageBox.Show("Plik został dodany pomyślnie");
                }
                else
                {
                    MessageBox.Show("Coś poszło nie tak, spróbuj jeszcze raz!");
                }
            }
        }
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
