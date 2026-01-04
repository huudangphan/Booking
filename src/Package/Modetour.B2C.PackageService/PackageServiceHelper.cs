using Modetour.B2C.Commons;
using Modetour.B2C.Commons.Helper;

namespace Modetour.B2C.PackageService
{
    public class PackageServiceHelper
    {
        public static string GetErrorMessage(string errorCode)
        {
            return MethodResultHelper.GetErrorMessage(errorCode, typeof(PackageServiceHelper).Assembly);
        }
    }
    public static class PackageServiceExtensions
    {
        public static void AddPackageServiceErrorMessage(this VoidMethodResult errorResult, string errorCode, string[] errorValues)
        {
            errorResult.AddErrorMessage(errorCode, PackageServiceHelper.GetErrorMessage(errorCode), errorValues);
        }

        public static void AddPackageServiceExceptionError(this VoidMethodResult errorResult, Exception ex)
        {
            ErrorResult error = new ErrorResult();
            error.ErrorCode = nameof(Constants.CommonErrors.InternalException);
            error.ErrorMessage = $"Error: {PackageServiceHelper.GetErrorMessage(nameof(Constants.CommonErrors.InternalException))}, Exception Message: {ex.Message}, " +
                $"Stack Trace: {ex.StackTrace ?? string.Empty}";
            error.ErrorValues = new List<string>();

            errorResult.AddErrorMessage(error);
        }

      

    }
}
