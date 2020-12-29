using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Shared.Interfaces.Repository;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;
using Shared.Models;
using DataLayer;
using Shared.Interfaces.Business;
using BusinessLayer;

namespace PresentationLayerWeb
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            container.RegisterType<ITableRepository, TableRepository>();
            container.RegisterType<ITableBusiness, TableBusiness>();

            container.RegisterType<IReceiptRepository, ReceiptRepository>();
            container.RegisterType<IReceiptBusiness, ReceiptBusiness>();

            container.RegisterType<IWaiterRepository, WaiterRepository>();
            container.RegisterType<IWaiterBusiness, WaiterBusiness>();

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductBusiness, ProductBusiness>();

            container.RegisterType<IReceiptItemRepository, ReceiptItemRepository>();
            container.RegisterType<IReceiptItemBusiness, ReceiptItemBusiness>();

           
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}