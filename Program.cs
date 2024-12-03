using Steeltoe.Discovery.Client;
using Steeltoe.Management.Endpoint.Health;

var builder = WebApplication.CreateBuilder(args);

// Add Steeltoe Discovery Client
builder.Services.AddDiscoveryClient();

// Add Steeltoe Health Check Actuator
builder.Services.AddHealthChecks();

// Add Steeltoe Health Management
builder.Services.AddHealthActuator();

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

// Use Steeltoe Discovery Client
app.UseDiscoveryClient();

// Map Health Checks and Controllers
app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health");
    endpoints.MapControllers();
});

app.Run();



//using Steeltoe.Discovery.Client;

//var builder = WebApplication.CreateBuilder(args);

//// Add Steeltoe Discovery Client
//builder.Services.AddDiscoveryClient();

//builder.Services.AddControllers();

//var app = builder.Build();

//app.UseRouting();

//// Use Steeltoe Discovery Client
//app.UseDiscoveryClient();

//app.MapControllers();

//app.Run();
