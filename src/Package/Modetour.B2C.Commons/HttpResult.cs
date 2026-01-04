using Modetour.B2C.Commons.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace Modetour.B2C.Commons
{
    public class HttpResult
    {
        public MessageCode messageCode { get; set; }
        public string message { get; set; }
        public object content { get; set; }
        public HttpResult()
        {

        }
        public HttpResult(MessageCode messageCode)
        {
            this.messageCode = messageCode;
        }
        public HttpResult(MessageCode messageCode, string message)
        {
            this.messageCode = messageCode;
            this.message = message;
        }
        public HttpResult(MessageCode messageCode, string message, object content)
        {
            this.messageCode = messageCode;
            this.message = message;
            this.content = content;
        }

    }
    public enum MessageCode
    {
        [Description("None")]
        None = 0,

        [Description("Success")]
        Success = 200,
        [Description("Unauthorized")]
        Unauthorized = 401,

        [Description("Error")]
        Error = 2,

        [Description("Exception")]
        Exception = 3,

        [Description("Token has been expired")]
        TokenExpired = 9,

        [Description("Invalid Token")]
        TokenInvalid = 10,

        [Description("Function not supported")]
        FunctionNotSupport = 13,

        #region Messgage database

        [Description("Unable access to database")]
        UnableAccessDatabase = 20,

        [Description("MessageCode in database not consistence with defined enums")]
        EnumDataInConsistence = 21,

        [Description("object_type not exists in system")]
        SystemObjectTypeNotExists = 22,

        [Description("MessageCode Enums Duplicated. Please contact administrator")]
        DuplicateMessageCode = 23,

        [Description("Special characters do not allow.")]
        SpecialCharacterNotAllow = 24,

        [Description("Type not supported")]
        TypeNotSupported = 26,

        [Description("Object type not supported")]
        ObjectTypeNotSupported = 27,
        #endregion

    }
    public class ErrorResult
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public IList<string> ErrorValues { get; set; } = new List<string>();
    }

    public class VoidMethodResult
    {
        private readonly List<ErrorResult> _errorMessages = new List<ErrorResult>();

        public void AddErrorMessage(ErrorResult errorResult) => _errorMessages.Add(errorResult);

        public void AddErrorMessages(ICollection<ErrorResult> errorResults) => _errorMessages.AddRange(errorResults);

        public void AddErrorMessage(string errorCode, string[] errorValues)
        {
            AddErrorMessage(errorCode, MethodResultHelper.GetCommonErrorMessage(errorCode), errorValues);
        }

        public void AddErrorMessage(string errorCode, object p, string[] errorValues)
        {
            throw new NotImplementedException();
        }

        public void AddErrorMessage(CommonErrors commonError, string errorMessage, string[] errorValues,
            string exceptionErrorMessage, string exceptionStackTrace)
        {
            AddErrorMessage(nameof(commonError), errorMessage, errorValues, exceptionErrorMessage, exceptionStackTrace);
        }

        public void AddErrorMessage(CommonErrors commonError, string errorMessage, string[] errorValues)
        {
            AddErrorMessage(nameof(commonError), errorMessage, errorValues);
        }

        public void AddErrorMessage(string errorCode, string errorMessage, string[] errorValues)
        {
            var errorResult = new ErrorResult
            {
                ErrorCode = errorCode,
                ErrorMessage = errorMessage
            };
            if (errorValues?.Length > 0)
                foreach (var errorValue in errorValues)
                    errorResult.ErrorValues.Add(errorValue);
            AddErrorMessage(errorResult);
        }

        public void AddErrorMessage(string exceptionErrorMessage, string exceptionStackTrace = "")
        {
            AddErrorMessage(CommonErrors.APIServerError
                , MethodResultHelper.GetCommonErrorMessage(CommonErrors.APIServerError)
                , new string[] { }, exceptionErrorMessage, exceptionStackTrace);
        }

        /// <summary>
        /// use for gremlin response exception
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <param name="errorValues"></param>
        public void AddCustomizeErrorMessage(
            string errorCode,
            string errorMessage,
            string[] errorValues)
        {
            _errorMessages.Add(new ErrorResult
            {
                ErrorCode = errorCode,
                ErrorMessage = $"Failed: {errorMessage}",
                ErrorValues = new List<string>(errorValues)
            });
        }

        private void AddErrorMessage(
            string errorCode,
            string errorMessage,
            string[] errorValues,
            string exceptionErrorMessage,
            string exceptionStackTrace)
        {
            _errorMessages.Add(new ErrorResult
            {
                ErrorCode = errorCode,
                ErrorMessage = $"Error: {errorMessage}, Exception Message: {exceptionErrorMessage}, Stack Trace: {exceptionStackTrace}",
                ErrorValues = new List<string>(errorValues)
            });
        }

        public IReadOnlyCollection<ErrorResult> ErrorMessages => _errorMessages;
        public bool IsOK => _errorMessages.Count == 0;

        public string ToJSONString()
        {
            return JsonConvert.SerializeObject(this,
                        new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        }
    }

    public class MethodResult<T> : VoidMethodResult
    {
        public T Result { get; set; }

        public bool IsEmptyList<LT>(List<LT> list, string errorValueName)
        {
            if (list == null || list.Count == 0)
            {
                AddErrorMessage(CommonErrors.Required,
                        MethodResultHelper.GetCommonErrorMessage(CommonErrors.Required),
                       new[] { MethodResultHelper.GenerateErrorMessage(errorValueName, "") });

                return true;
            }
            return false;
        }

        public bool IsValidEnumValue<ET>(List<ET> enumValues, string errorValueName, string errorCode,
            Assembly currentExecutingAssembly) where ET : Enum
        {
            IList<ET> invalidEnumValues = MethodResultHelper.GetInvalidEnumValues(enumValues);
            if (invalidEnumValues.Any())
            {
                AddErrorMessage(errorCode, MethodResultHelper.GetErrorMessage(errorCode, currentExecutingAssembly),
                       new[] { MethodResultHelper.GenerateErrorMessage(errorValueName,
                       string.Join(',', invalidEnumValues.Select(e => Convert.ToInt32(e, CultureInfo.InvariantCulture)))) });
                return false;
            }

            return true;
        }

        public bool IsDuplicatedEnumValue<ET>(List<ET> enumValues, string errorValueName, string errorCode,
             Assembly currentExecutingAssembly) where ET : Enum
        {
            bool isDuplicated = false;
            IList<ET> duplicateValues = MethodResultHelper.GetDuplicatedEnumValues(enumValues);
            if (duplicateValues.Any())
            {
                AddErrorMessage(errorCode, MethodResultHelper.GetErrorMessage(errorCode, currentExecutingAssembly),
                      new[] { MethodResultHelper.GenerateErrorMessage(errorValueName,
                      string.Join(',', duplicateValues.Select(e => Convert.ToInt32(e, CultureInfo.InvariantCulture)))) });
                isDuplicated = true;
            }
            return isDuplicated;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1000:Do not declare static members on generic types", Justification = "<Pending>")]
        public static MethodResult<T> CreateResultFromErrorList(IEnumerable<ErrorResult> errorMessages)
        {
            var methodResult = new MethodResult<T>();
            foreach (var error in errorMessages)
                methodResult.AddErrorMessage(error);
            return methodResult;
        }

        public void AddResultFromErrorList(IEnumerable<ErrorResult> errorMessages)
        {
            foreach (var error in errorMessages)
                AddErrorMessage(error);
        }
       
    }
    public enum CommonErrors
    {
        /// <summary>
        /// API Service Error
        /// </summary>
        APIServerError = 1,

        /// <summary>
        /// UnAuthorize
        /// </summary>
        UnAuthorize,

        /// <summary>
        /// Missing required field
        /// </summary>
        Required,

        /// <summary>
        /// The web service has not worked correctly. Please contact the Administrator.
        /// </summary>
        WebServiceError,

        /// <summary>
        /// Exception from internal handler
        /// </summary>
        InternalException
    }
}
