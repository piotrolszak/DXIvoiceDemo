using DXIvoiceDemo.Model.EF;

namespace DXIvoiceDemo.Model.Interfaces
{
    /// <summary>
    /// Interface for Invoice Repository to handle CRUD operations for Invoice entities.
    /// </summary>
    public interface IInvoiceRepository
    {
        /// <summary>
        /// Retrieves a list of all invoices.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of invoices.</returns>
        Task<List<Invoice>> GetInvoices();

        /// <summary>
        /// Adds a new invoice to the repository.
        /// </summary>
        /// <param name="invoice">The invoice to add.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task Add(Invoice invoice);

        /// <summary>
        /// Updates an existing invoice in the repository.
        /// </summary>
        /// <param name="invoice">The invoice to update.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task Update(Invoice invoice);

        /// Deletes an invoice from the repository.
        /// </summary>
        /// <param name="Id">The ID of the invoice to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task Delete(Guid Id);
    }
}