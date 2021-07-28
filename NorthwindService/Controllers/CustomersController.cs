using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NorthwindService.Repositories;
using Packt.Shared;
using Microsoft.AspNetCore.Http;

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

        [HttpGet("{id}",Name=nameof(GetCustomer))]
        [ProducesResponseType(200,Type =typeof(Customer))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetCustomer(string id)
        {
            Customer c = await repo.RetrieveAsync(id);
            if (c==null)
            {
                return NotFound();
            }
            return Ok (c);
        }
         
         [HttpPost]
         [ProducesResponseType(201,Type =typeof(Customer))]
         [ProducesResponseType(200)]

         public async Task<IActionResult> Create([FromBody] Customer c)
         {  

             
             if(! ModelState.IsValid)
             {
                 return BadRequest(ModelState);
             }
              Customer added = await repo.CreateAsync(c);

              return CreatedAtRoute(routeName:nameof(GetCustomer),routeValues:new {id= added.CustomerID.ToLower()},value:added);
         }
        
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(string id , [FromBody]Customer c)
        {
            id = id.ToUpper();
            c.CustomerID= c.CustomerID.ToUpper();

            if (c == null || id != c.CustomerID)
            {
                return BadRequest();
            } 

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 

            var existing = await repo.RetrieveAsync(id);

            if (existing==null)
            {
                return NotFound();
            } 

            await repo.UpdateAsync(id,c);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

         public async Task<IActionResult> Delete(string id )
         {
             var exisitng = await repo.RetrieveAsync(id);
             if (exisitng==null)
             {
                 return NotFound();
             } 

             bool? deleteted = await repo.DeleteAsync(id);
             if(deleteted.HasValue&& deleteted.Value)
             {
                 return new NoContentResult();
             } else
             {
                 return BadRequest($"Customer {id} was found but failed to delete");
             }
         }

    }
}
