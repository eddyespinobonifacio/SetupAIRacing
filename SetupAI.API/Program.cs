using SetupAI.API.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Registry Services
builder.Services.AddControllers();
builder.Services.AddSingleton<TelemetryStore>();// Inyection dependencies for our service in memory

// Documentation OpenAPI (Swagger)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SetupAI API", Version = "v1" });
});

var app = builder.Build();

// Pipeline HTTP Configuration
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();




