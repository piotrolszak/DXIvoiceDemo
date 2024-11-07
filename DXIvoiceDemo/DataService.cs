using DXIvoiceDemo.Model.EF;
using DXIvoiceDemo.Model.Interfaces;
using DXIvoiceDemo.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DXIvoiceDemo
{
    public class DataService : IDataService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IInvoiceRepository _invoiceRepository;

        public DataService(ICustomerRepository customerRepository, IInvoiceRepository invoiceRepository)
        {
            _customerRepository = customerRepository;
            _invoiceRepository = invoiceRepository;
        }

        /// <summary>
        /// Generates a list of customers with random data.
        /// </summary>
        /// <param name="numberOfCustomers">The number of customers to generate.</param>
        /// <param name="customerTypes">Array of customer types to randomly assign to customers.</param>
        /// <param name="random">Random instance for generating random values.</param>
        /// <returns>A list of generated customers.</returns>
        public List<Customer> GenerateCustomers(int numberOfCustomers, Array customerTypes, Random random)
        {
            var customers = new List<Customer>();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                var customer = new Customer
                {
                    Id = Guid.NewGuid(),
                    Type = (CustomerType)customerTypes.GetValue(random.Next(customerTypes.Length)),
                    Name = $"Customer {i + 1 + random.Next()}",
                    Code = $"CUST{i + random.Next() + 1:D4}",
                    Address = $"Address {i + 1 + random.Next()}",
                    City = $"City {i + 1 + random.Next()}",
                    Country = "Country",
                    TIN = $"TIN{i + random.Next() + 1:D4}",
                    Email = $"customer{i + random.Next() + 1}@example.com",
                    Active = true
                };
                customers.Add(customer);
            }
            return customers;
        }

        /// <summary>
        /// Generates a list of invoices for given customers.
        /// </summary>
        /// <param name="numberOfInvoices">The number of invoices to generate.</param>
        /// <param name="customers">The list of customers to associate with the invoices.</param>
        /// <param name="random">Random instance for generating random values.</param>
        /// <returns>A list of generated invoices.</returns>
        public List<Invoice> GenerateInvoices(int numberOfInvoices, List<Customer> customers, Random random)
        {
            var invoices = new List<Invoice>();
            for (int i = 0; i < numberOfInvoices; i++)
            {
                var customer = customers[random.Next(customers.Count)];
                var invoice = new Invoice
                {
                    Id = Guid.NewGuid(),
                    Number = $"INV{i + 1 + random.Next():D4}",
                    SaleDate = DateTime.Now.AddDays(-random.Next(100)),
                    TotalNet = random.Next(1000, 10000),
                    CustomerId = customer.Id,
                    VatRate = random.Next(5, 25),
                    Description = $"Invoice for {customer.Name}",
                    Currency = "USD",
                    Customer = customer
                };
                invoices.Add(invoice);
            }
            return invoices;
        }

        /// <summary>
        /// Adds a list of customers to the repository.
        /// </summary>
        /// <param name="customers">The list of customers to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task AddCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                await _customerRepository.Add(customer);
            }
        }

        /// <summary>
        /// Adds a list of invoices to the repository.
        /// </summary>
        /// <param name="invoices">The list of invoices to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task AddInvoices(List<Invoice> invoices)
        {
            foreach (var invoice in invoices)
            {
                await _invoiceRepository.Add(invoice);
            }
        }

        /// <summary>
        /// Exports a list of data to a CSV file.
        /// </summary>
        /// <typeparam name="T">The type of data to export.</typeparam>
        /// <param name="data">The list of data to export.</param>
        /// <param name="fileName">The name of the CSV file.</param>
        public void ExportToCSV<T>(List<T> data, string fileName)
        {
            if (data == null || data.Count == 0)
            {
                return;
            }
            var sb = new StringBuilder();
            var properties = typeof(T).GetProperties();
            sb.AppendLine(string.Join(";", properties.Select(p => p.Name)));

            foreach (var item in data)
            {
                sb.AppendLine(string.Join(";", properties.Select(p => p.GetValue(item).ToString())));
            }

            System.IO.File.WriteAllText(fileName, sb.ToString());
        }

        /// <summary>
        /// Exports a list of data to an XML file.
        /// </summary>
        /// <typeparam name="T">The type of data to export.</typeparam>
        /// <param name="data">The list of data to export.</param>
        /// <param name="fileName">The name of the XML file.</param>
        public void ExportToXML<T>(List<T> data, string fileName)
        {
            if (data == null || data.Count == 0)
            {
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(fs, data);
            }
        }
    }
}
