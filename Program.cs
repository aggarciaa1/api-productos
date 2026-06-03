using Prometheus;
using Api_productos.Services;
var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<CustomerService>();

builder.Services.AddHealthChecks();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Métricas
app.UseHttpMetrics();

app.MapMetrics();

// Health
app.MapHealthChecks("/health");

// Controllers
app.MapControllers();

app.Run();