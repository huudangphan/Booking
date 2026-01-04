using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Reflection;
using static Modetour.B2C.Commons.Constants;

namespace Modetour.B2C.Commons.Helper
{
    public static class MethodResultHelper
    {
        private static ConcurrentDictionary<string, Dictionary<string, string>> _errorMessages;

        public static string GenerateErrorMessage(string name, object value)
        {
            return $"{name}:{JsonHelper.ConvertObjectToString(value)}";
        }

        public static string GetCommonErrorMessage(string errorCode)
        {
            return GetErrorMessage(errorCode, Assembly.GetExecutingAssembly());
        }

        public static string GetErrorMessage(string errorCode, Assembly resourceAssembly)
        {
            return GetErrorMessage(errorCode, ref _errorMessages, resourceAssembly);
        }

        public static string GetCommonErrorMessage(CommonErrors commonError)
        {
            return GetErrorMessage(nameof(commonError), Assembly.GetExecutingAssembly());
        }

        private static string GetErrorMessage(string errorCode, ref ConcurrentDictionary<string, Dictionary<string, string>> errorMessages, Assembly resourceAssembly)
        {
            string defaultErrorMessage = "No pre-define error message";
            if (resourceAssembly == null) return defaultErrorMessage;

            Dictionary<string, string>? messages = null;
            string defaultLanguage = "EN";
            var dictionaryKey = $"{resourceAssembly.GetName().Name}@@{defaultLanguage}";
            try
            {
                if (errorMessages != null)
                {
                    messages = errorMessages[dictionaryKey];
                }
            }
            catch (Exception)
            {
                //Ignore
            }

            if (messages == null)
            {
                try
                {
                    string jsonErrorFilePath = $"{Settings.ResourceFolderName}.{Settings.ErrorFileName}-{defaultLanguage}.json";
                    var fileData = GetFromResource(jsonErrorFilePath, resourceAssembly);
                    messages = JsonConvert.DeserializeObject<Dictionary<string, string>>(fileData);
                }
                catch (Exception)
                {
                    messages = new Dictionary<string, string>();
                }
            }

            if (messages != null)
            {
                defaultErrorMessage = messages.Keys.Contains(errorCode) ? messages[errorCode] : defaultErrorMessage;
            }
            return defaultErrorMessage;
        }

        private static string GetFromResource(string jsonErrorFilePath, Assembly resourceAssembly)
        {
            string result = string.Empty;
            jsonErrorFilePath = $"{resourceAssembly.GetName().Name}.{jsonErrorFilePath}";

            using (Stream stream = resourceAssembly.GetManifestResourceStream(jsonErrorFilePath))
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

        public static List<ET> GetInvalidEnumValues<ET>(List<ET> enumValues)
        {
            if (enumValues == null || !enumValues.Any()) return new List<ET>();

            List<ET> result = new List<ET>();
            foreach (ET enumValue in enumValues)
            {
                if (!Enum.IsDefined(typeof(ET), nameof(enumValue)))
                    result.Add(enumValue);
            }
            return enumValues;
        }

        public static List<ET> GetDuplicatedEnumValues<ET>(List<ET> enumValues) where ET : notnull
        {
            if (enumValues == null || !enumValues.Any()) return new List<ET>();

            List<ET> result = new List<ET>();
            Dictionary<ET, int> keyValuePairs = enumValues.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .ToDictionary(x => x.Key, y => y.Count());

            foreach (ET enumValue in keyValuePairs.Keys)
            {
                if (keyValuePairs[enumValue] > 1)
                    result.Add(enumValue);
            }

            return enumValues;
        }

        public static string GetExceptionMessage(Exception exception)
        {
            return exception.ToString();
        }
    }

    public class Settings
    {
        public static readonly string ResourceFolderName = "Resources";
        public static readonly string ErrorFileName = "ErrorMessage";
    }
}