using Api_productos.Models;

namespace Api_productos.Services;

public class CustomerService
{
    private readonly List<Customer> _customers = [];

    public List<Customer> GetAll()
    {
        return _customers;
    }

    public Customer? Get(Guid id)
    {
        return _customers.FirstOrDefault(x => x.Id == id);
    }

    public Customer Create(Customer customer)
    {
        customer.Id = Guid.NewGuid();

        _customers.Add(customer);

        return customer;
    }

    public void Delete(Guid id)
    {
        var customer = Get(id);

        if (customer != null)
            _customers.Remove(customer);
    }
}