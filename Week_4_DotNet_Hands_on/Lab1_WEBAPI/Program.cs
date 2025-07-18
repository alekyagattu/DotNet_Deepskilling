using Lab1;

var builder = WebApplication.CreateBuilder(args);

// Load Startup
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
startup.Configure(app, app.Environment);

app.Run();

