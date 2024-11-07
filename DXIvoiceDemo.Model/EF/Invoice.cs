using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXIvoiceDemo.Model.EF
{
    public sealed class Invoice
    {
        public Invoice()
        {
            Id = Guid.NewGuid();
            Number = string.Empty;
            SaleDate = DateTime.Now;
            TotalNet = 0;
            CustomerId = Guid.Empty;
            VatRate = 0;
            Description = string.Empty;
            Currency = "EUR";
            CustomerId = Guid.Empty;    
        }
        public Guid Id { get; set; }
        public string Number { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalNet { get; set; }
        public Guid CustomerId { get; set; }
        public int VatRate { get; set; }
        public string? Description { get; set; }
        public string Currency { get; set; }
        public Customer Customer { get; set; }
    }
}
