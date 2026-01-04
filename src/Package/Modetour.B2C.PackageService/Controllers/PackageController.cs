using Microsoft.AspNetCore.Mvc;
using Modetour.B2C.Commons;



namespace Modetour.B2C.PackageService.Controllers
{

    [ApiController]
    public class PackageController : ControllerBase
    {

        public PackageController()
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