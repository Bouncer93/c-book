using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NorthwindService.Repositories;
using Packt.Shared;

namespace NorthwindService.Controllers
{

    [Route("[api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
       
        private ICustomerRepository repo;

        public CustomersController(ICustomerRepository repo)
        {
           this.repo= repo;
        } 

        [HttpGet]
        [ProducesResponseType(200,Type =typeof(IEnumerable<Customer>))]
        public async Task<IEnumerable<Customer>> GetCustomers(string country)
        {
            if(string.IsNullOrWhiteSpace(country))
            {
                return await repo.RetrieveAllAsync();
            } else
            {
                return(await repo.RetrieveAllAsync()).Where(customer=>customer.Country==country);
            }
        }

        
    }
}
