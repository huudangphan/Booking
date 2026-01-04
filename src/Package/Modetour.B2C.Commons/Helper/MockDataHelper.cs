using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Modetour.B2C.Commons.Helper
{
    public static class MockDataHelper
    {
        public static string ReadFile(string filePath)
        {
            string textFile = filePath;
            string text = "";
            if (File.Exists(textFile))
            {
                text = File.ReadAllText(textFile);
                return text;
            }
            return text;
        }

        public static Dictionary<string, string> ReadAllFile(string rootFolder)
        {
            List<string> lstFileName = GetAllFileName(rootFolder);
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (var item in lstFileName)
            {
                result.Add(item, ReadFile(rootFolder + item));
            }
            return result;
        }
        public static List<string> GetAllFileName(string rootFolder)
        {
            DirectoryInfo di = new DirectoryInfo(rootFolder);
            FileInfo[] files = di.GetFiles("*.xml");

            List<string> lstFileName = new List<string>();
            foreach (var item in files)
            {
                lstFileName.Add(item.Name);
            }
            return lstFileName;
        }
        public static void SaveFile(string fileName, string content, string rootFolder)
        {
            FormatContent(ref content);
            string filePath = rootFolder + fileName + ".json";
            File.WriteAllText(filePath, content);
        }
        private static void FormatContent(ref string content)
        {
            content = content.Replace("@", "");
            content = content.Replace("#", "");
            content = content.Replace("cdata-section", "value");
        }
        public static string ReadFile(string fileName, string folder)
        {
            return File.ReadAllText(@"./MockData/" + fileName + ".json");
        }
        public static string Serialize(object dataToSerialize)
        {
            if (dataToSerialize == null) return null;

            using (StringWriter stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(dataToSerialize.GetType());
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
        }
    }
}
