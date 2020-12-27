using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider()) 
            {
                var main = serviceProvider.GetRequiredService<Main>();
                Application.Run(main);
            }               
        }

        private static void ConfigureServices(ServiceCollection services) 
        {
            services.AddSingleton<ITableRepository, TableRepository>();
            services.AddSingleton<ITableBusiness, TableBusiness>();

            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IProductBusiness, ProductBusiness>();

            services.AddSingleton<IReceiptRepository, ReceiptRepository>();
            services.AddSingleton<IReceiptBusiness, ReceiptBusiness>();

            services.AddSingleton<IReceiptItemRepository, ReceiptItemRepository>();
            services.AddSingleton<IReceiptItemBusiness, ReceiptItemBusiness>();

            services.AddSingleton<IWaiterRepository, WaiterRepository>();
            services.AddSingleton<IWaiterBusiness, WaiterBusiness>();

            services.AddSingleton<Main>();
            services.AddSingleton<TableOverview>();
            services.AddSingleton<ReceiptOverview>();
            services.AddSingleton<WaiterAddUpdate>();
            services.AddSingleton<ProductAddUpdate>();
            services.AddSingleton<Login>();
            services.AddSingleton<TableProducts>();
            services.AddSingleton<TableReceipts>();
            services.AddSingleton<TableWaiter>();
        }
    }
}
