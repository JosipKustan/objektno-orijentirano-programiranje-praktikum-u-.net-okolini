using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.FileIO
{
    public class FileIO
    {
        public static async Task<T> FetchJsonFromFileAsync<T>(String path)
        {
            var sr = new StreamReader(path);
            var iobuffer = await sr.ReadToEndAsync();
            sr.Close();
            return JsonConvert.DeserializeObject<T>(iobuffer);
        }
        public static T FetchObjectFromJsonFile<T>(String path)
        {
            
            var sr = new StreamReader(path);
            var iobuffer = sr.ReadToEnd();
            sr.Close();
            return JsonConvert.DeserializeObject<T>(iobuffer);
            
        }

        public static void WriteJsonToFile(String path,String json)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(json);
            sw.Close();

        }
    }
}
