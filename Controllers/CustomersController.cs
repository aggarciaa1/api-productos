using Api_productos.Models;
using Api_productos.Services;
using Microsoft.AspNetCore.Mvc;
using ErrorPrueba;
namespace Api_productos.Controllers;

[ApiController]
[Route("api/customers")]
public class CustomersController : ControllerBase
{
    private readonly CustomerService _service;

    public CustomersController(CustomerService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var customer = _service.Get(id);

        if (customer == null)
            return NotFound();

        return Ok(customer);
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        return Ok(_service.Create(customer));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _service.Delete(id);

        return NoContent();
    }
}