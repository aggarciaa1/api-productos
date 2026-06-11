using Microsoft.AspNetCore.Mvc;

namespace Api_productos.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
        return Ok(new
        {
            mensaje = "Hola Kubernetes",
            version = Environment.GetEnvironmentVariable("APP_VERSION"),
            environment = Environment.GetEnvironmentVariable("APP_ENVIRONMENT"),
            db_user = Environment.GetEnvironmentVariable("DB_USER"),
            db_password = dbPassword,
         
            dbPasswordConfigured = !string.IsNullOrEmpty(dbPassword)
        });
    }
}