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
            version = "2.0",
            sha = Environment.GetEnvironmentVariable("GITHUB_SHA")
        });
    }
}