using DXIvoiceDemo.Model;
using DXIvoiceDemo.Model.EF;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DXIvoiceDemo.Services
{
    public interface IDataService
    {
        Task AddCustomers(List<Customer> customers);
        Task AddInvoices(List<Invoice> invoices);
        List<Customer> GenerateCustomers(int numberOfCustomers, Array customerTypes, Random random);
        List<Invoice> GenerateInvoices(int numberOfInvoices, List<Customer> customers, Random random);
        public void ExportToCSV<T>(List<T> data, string fileName);
        public void ExportToXML<T>(List<T> data, string fileName);
    }
}
