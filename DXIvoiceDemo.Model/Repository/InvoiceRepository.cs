using DXIvoiceDemo.Model.EF;
using DXIvoiceDemo.Model.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXIvoiceDemo.Model.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Invoice>> GetInvoices()
        {
            return await _context.Invoices.ToListAsync();
        }

        public async Task Add(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            _ = _context.Invoices.Where(a=>a.Id == Id).ExecuteDeleteAsync();
            await _context.SaveChangesAsync();
        }
    }
}
