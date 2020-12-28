using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        private IWaiterBusiness waiterBusiness;
        public _Default(IWaiterBusiness _waiterBusiness)
        {
            this.waiterBusiness = _waiterBusiness;
        }
        public void getLoginID(int id)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Waiter> waiters = this.waiterBusiness.getLoggedWaiters();
            int num = waiters.Count;
            if(num >= 1) 
                A0.InnerHtml = waiters[0].Name.ToString();

            if (num >= 2)
                A1.InnerHtml = waiters[1].Name.ToString();
        }
        protected void login_ServerClick1(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=1");
        }
        protected void login_ServerClick2(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=2");
        }
    }
}