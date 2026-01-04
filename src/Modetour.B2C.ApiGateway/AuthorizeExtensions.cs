using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace Modetour.B2C.ApiGateway
{
    public static class AuthorizeExtensions
    {
        public static void AddAuthorize(this IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.Authority = "https://cm-identity-79.modetour.biz";

                // BELOW ARE FOR TESTING.
                // TODO: control by env variable
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    SignatureValidator = delegate (string token, TokenValidationParameters parameters)
                    {
                        var jwt = new JwtSecurityToken(token);
                        return jwt;
                    },
                    ValidateActor = false,
                    ValidateIssuer = false,
                    ValidateIssuerSigningKey = false,
                    ValidateLifetime = false,
                    ValidateTokenReplay = false
                };
            });
            services.AddAuthorization(options =>
            options.AddPolicy("ApiScope", policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", "openid", "profile", "modetour_member", "ptid");
            }));
        }
    }
}