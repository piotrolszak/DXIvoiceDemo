using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraWaitForm;
using DXIvoiceDemo.Model;
using DXIvoiceDemo.Model.Interfaces;
using DXIvoiceDemo.Model.Repository;
using DXIvoiceDemo.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace DXIvoiceDemo
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Form1());



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Konfiguracja kontenera DI
            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            ApplyMigrations();

            // Uruchomienie aplikacji z głównym formularzem, wstrzykniętym przez DI
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Rejestracja DbContext z connection stringiem z App.config
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Rejestracja formularzy
            services.AddTransient<Form1>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IDataService, DataService>();

        }

        private static void ApplyMigrations()
        {
            using (var scope = ServiceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                try
                {
                    // Automatyczne stosowanie migracji
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas stosowania migracji: {ex.Message}", "Błąd migracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1); // Zamknięcie aplikacji w przypadku błędu
                }
            }
        }
    }
}
