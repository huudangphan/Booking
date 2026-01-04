using Microsoft.OpenApi.Models;
using MMLib.SwaggerForOcelot.DependencyInjection;
using Modetour.B2C.ApiGateway;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Provider.Polly;

var builder = WebApplication.CreateBuilder(args);
var routes = "Routes";

builder.Configuration.AddOcelotWithSwaggerSupport(options =>
{
    options.Folder = routes;
});
builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    .AddOcelot(routes, builder.Environment)
    .AddEnvironmentVariables();
// Add services to the container.

builder.Services.AddOcelot(builder.Configuration).AddPolly().AddConsul().AddCacheManager(x =>
{
    x.WithDictionaryHandle();
});

builder.Services.AddSwaggerForOcelot(builder.Configuration);
//builder.Services.AddHostedService<TimedHostedService>();

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.ConfigureDownstreamHostAndPortsPlaceholders(builder.Configuration);

// Swagger for ocelot
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorize();
var app = builder.Build();
var config = app.Configuration;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

app.UseHttpsRedirection();
app.UseCors(b => b
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
            );
app.UseAuthorization();
app.UseAuthentication();
app.UseSwaggerForOcelotUI(options =>
{
    options.PathToSwaggerGenerator = "/swagger/docs";
    options.ReConfigureUpstreamSwaggerJson = AlterUpstream.AlterUpstreamSwaggerJson;
    options.DownstreamSwaggerHeaders = new[]
  {
      new KeyValuePair<string, string>("Auth-Key", "AuthValue"),
  };
    options.ServerOcelot = "/siteName/apigateway";

}).UseOcelot().Wait();

app.MapControllers();

app.Run();