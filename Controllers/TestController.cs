using Microsoft.AspNetCore.Mvc;

namespace Api_productos.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            mensaje = "Hola Kubernetes",
            version = Environment.GetEnvironmentVariable("APP_VERSION"),
            environment = Environment.GetEnvironmentVariable("APP_ENVIRONMENT"),
            
        });
    }
}