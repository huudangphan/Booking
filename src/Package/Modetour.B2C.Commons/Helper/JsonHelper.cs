using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Helper
{
    public class JsonHelper
    {
        public static object ConvertStringToObject(string json, Type type)
        {
            object result = null;
            try
            {
                result = JsonConvert.DeserializeObject(json,type);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return result;
        }

        public static string ConvertObjectToString(object obj)
        {
            string result = string.Empty;
            //Migration Issue : obj 예외 처리
            if (obj == null)
                return result;

            if (obj.GetType() == typeof(string))
            {
                result = obj.ToString();
            } else {
                result = JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
            return result;
        }
    }
}
