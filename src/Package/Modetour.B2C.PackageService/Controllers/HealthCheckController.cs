using Microsoft.AspNetCore.Mvc;
using Modetour.B2C.Commons;
using Modetour.B2C.Commons.Helper;



namespace Modetour.B2C.PackageService.Controllers
{

    [ApiController]
    public class HealthCheckController : ControllerBase
    {

        public HealthCheckController()
        {
        }

        [HttpGet]
        [Route("healthcheck")]
        public HttpResult HealthCheck()
        {
            return new HttpResult()
            {
                messageCode = MessageCode.Success,
                message = "",
                content = ""
            };
        }

    }
}