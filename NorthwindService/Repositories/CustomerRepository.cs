using Microsoft.EntityFrameworkCore.ChangeTracking;
using Packt.Shared;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindService.Repositories
{
    public class CustomerRepository : ICustomerRepository

    {
        private static ConcurrentDictionary <string, Customer> customersCache;
        private Northwind db;
        public CustomerRepository(Northwind db)
        {
            this.db = db;
            // pre-load customers from database as a normal
// Dictionary with CustomerID as the key,
// then convert to a thread-safe ConcurrentDictionary

if (customersCache == null)
{
customersCache = new ConcurrentDictionary<string, Customer>(
db.Customers.ToDictionary(c => c.CustomerID));
}
        }
    }
}