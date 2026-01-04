using Microsoft.AspNetCore.Mvc.Filters;
using Modetour.B2C.Commons;
using System.IdentityModel.Tokens.Jwt;

namespace Modetour.B2C.PackageService
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ValidateRequest : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                string token = Functions.ToString(context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last());
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                GlobalData.ptId = Functions.ToString(tokenS.Claims.First(claim => claim.Type == "ptid").Value);
                GlobalData.userName = Functions.ToString(tokenS.Claims.First(claim => claim.Type == "preferred_username").Value);
                Console.WriteLine(tokenS);
            }
            catch (Exception ex)
            {
                GlobalData.ptId = String.Empty;
                GlobalData.userName = String.Empty;
            }
        }
    }
}
