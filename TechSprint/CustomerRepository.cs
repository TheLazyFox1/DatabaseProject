using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSprint
{
    public class CustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository()
        {
            _context = new AppDbContext();
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
