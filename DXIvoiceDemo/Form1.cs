using DevExpress.CodeParser;
using DevExpress.XtraTreeList.Native;
using DXIvoiceDemo.Model;
using DXIvoiceDemo.Model.EF;
using DXIvoiceDemo.Model.Interfaces;
using DXIvoiceDemo.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DXIvoiceDemo
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IDataService _dataService;
        private List<Invoice> _invoices;
        private List<Customer> _customers;
        public Form1(ICustomerRepository customerRepository, IInvoiceRepository invoiceRepository, IDataService dataService)
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _invoiceRepository = invoiceRepository;
            _dataService = dataService;
        }

        private async void LoadData()
        {
            await LoadInvoices();
            await LoadCustomers();
        }

        private async Task LoadInvoices()
        {
            _invoices = await _invoiceRepository.GetInvoices();

            gcInvoice.DataSource = _invoices;
            gcInvoice.RefreshDataSource();
        }

        private async Task LoadCustomers()
        {
            _customers = await _customerRepository.GetCustomers();

            gcCustomers.DataSource = _customers;
            gcCustomers.RefreshDataSource();
        }

        private async void bbiGeneateCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var random = new Random();
            var customerTypes = Enum.GetValues(typeof(CustomerType));
            var numberOfCustomers = Convert.ToInt32(beiNumberObject.EditValue);

            var customers = _dataService.GenerateCustomers(numberOfCustomers, customerTypes, random);
            await _dataService.AddCustomers(customers);
            await LoadCustomers();
        }

        private async void gvInvoice_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row == null)
            {
                var invoice = new Invoice();
                invoice.Id = Guid.NewGuid();
                await _invoiceRepository.Add(invoice);
                await LoadInvoices();
            }
            else
            {
                await _invoiceRepository.Update(e.Row as Invoice);
            }
        }

        private async void gvCustomers_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row == null)
            {
                var customer = new Customer();
                customer.Id = Guid.NewGuid();
                await _customerRepository.Add(customer);
                await LoadCustomers();
            }
            else
            {
                await _customerRepository.Update(e.Row as Customer);
            }
        }

        private async void bbiGenerateInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var random = new Random();
            var customerTypes = Enum.GetValues(typeof(CustomerType));
            var numberOfInvoices = Convert.ToInt32(beiNumberObject.EditValue);

            var invoices = _dataService.GenerateInvoices(numberOfInvoices, _customers, random);
            await _dataService.AddInvoices(invoices);
            await LoadInvoices();
        }

        private async void gcInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            var gridControl = sender as DevExpress.XtraGrid.GridControl;
            var view = gridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.KeyCode == Keys.Delete && view.SelectedRowsCount > 0)
            {
                var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć wybrane wiersze?", "Potwierdzenie", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var rowHandle in view.GetSelectedRows())
                    {
                        var row = view.GetRow(rowHandle) as Invoice;
                        if (row != null)
                        {
                            await _invoiceRepository.Delete(row.Id);
                        }
                    }
                    MessageBox.Show("Wiersze zostały usunięte.");
                }
            }
            await LoadInvoices();
        }

        private async void gvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.KeyCode == Keys.Delete && view.SelectedRowsCount > 0)
            {
                var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć wybrane wiersze?", "Potwierdzenie", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var rowHandle in view.GetSelectedRows())
                    {
                        var row = view.GetRow(rowHandle) as Customer;
                        if (row != null)
                        {
                            row.Active = false;
                            await _customerRepository.Update(row);
                        }
                    }
                    MessageBox.Show("Wiersze zostały usunięte.");
                }
            }
            await LoadCustomers();
        }

        private void bbiExportCSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    if (xtcData.SelectedTabPage.Name == "xtpInvoice")
                    {
                        _dataService.ExportToCSV(_invoices, fileName);
                    }
                    else if (xtcData.SelectedTabPage.Name == "xtpCustomers")
                    {
                        _dataService.ExportToCSV(_customers, fileName);
                    }
                }
            }
        }

        private void bbiExportXML_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.Title = "Save XML File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    if (xtcData.SelectedTabPage.Name == "xtpInvoice")
                    {
                        _dataService.ExportToXML(_invoices, fileName);
                    }
                    else if (xtcData.SelectedTabPage.Name == "xtpCustomers")
                    {
                        _dataService.ExportToXML(_customers, fileName);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bbiExportPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf";    
                saveFileDialog.Title = "Zapisz jako";         
                saveFileDialog.FileName = "GridExport.pdf";   

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (xtcData.SelectedTabPage.Name == "xtpInvoice")
                    {
                        gcInvoice.ExportToPdf(filePath);
                    }
                    else if (xtcData.SelectedTabPage.Name == "xtpCustomers")
                    {
                        gcCustomers.ExportToPdf(filePath);
                    }

                    MessageBox.Show("Dane zostały wyeksportowane do PDF!", "Eksport", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
