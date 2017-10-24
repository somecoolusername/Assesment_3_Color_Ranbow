using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;

namespace JsonHandler
{
    public static class JsonHandler
    {
        /// <summary>
        /// Returns serialize json object from Object passed,
        /// Intented formatted
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToSerializeJsonObject(Object obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            return json;
        }

        /// <summary>
        /// Writes json object to file specified
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="arr"></param>
        public static void WriteJsonToFile<T>(string filename, T[] arr)
        {
            string json = JsonConvert.SerializeObject(arr, Formatting.Indented);
            System.IO.File.WriteAllText(filename, json);
        }

        /// <summary>
        /// Returns deserialize json object from Object passed,
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T ToDeserializeJsonObject<T>(string obj)
        {
            T json = JsonConvert.DeserializeObject<T>(obj);
            return json;
        }
    }
}
