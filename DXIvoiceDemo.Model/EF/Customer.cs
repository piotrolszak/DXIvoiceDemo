using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXIvoiceDemo.Model.EF
{
    public sealed class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
            Type = CustomerType.Company;
            Active = true;
            Name = string.Empty;
            Code = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            Country = string.Empty;
            TIN = string.Empty;
            Email = string.Empty;
        }

        public Guid Id { get; set; }
        public CustomerType Type { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TIN { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
