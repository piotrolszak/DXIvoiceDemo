using DXIvoiceDemo.Model.EF;

namespace DXIvoiceDemo.Model.Interfaces
{
    /// <summary>
    /// Interface for customer repository to handle customer data operations.
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Retrieves a list of all customers.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of customers.</returns>
        Task<List<Customer>> GetCustomers();

        /// <summary>
        /// Adds a new customer.
        /// </summary>
        /// <param name="customer">The customer to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task Add(Customer customer);

        /// <summary>
        /// Updates an existing customer.
        /// </summary>
        /// <param name="customer">The customer to update.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task Update(Customer customer);
    }
}