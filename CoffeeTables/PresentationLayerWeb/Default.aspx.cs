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
        private List<Waiter> waiters;
        private IWaiterBusiness waiterBusiness;
        public _Default(IWaiterBusiness _waiterBusiness)
        {
            this.waiterBusiness = _waiterBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            waiters = this.waiterBusiness.getLoggedWaiters();
            int num = waiters.Count;
            if(num >= 1) 
                A0.InnerHtml = waiters[0].Name.ToString();
            if (num >= 2)
                A1.InnerHtml = waiters[1].Name.ToString();
            if (num >= 3)
                A2.InnerHtml = waiters[2].Name.ToString();
            if (num >= 4)
                A3.InnerHtml = waiters[3].Name.ToString();
            if (num >= 5)
                A4.InnerHtml = waiters[4].Name.ToString();

        }
        protected void login_ServerClick1(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=" + waiters[0].Id);
        }
        protected void login_ServerClick2(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=" + waiters[1].Id);
        }
        protected void login_ServerClick3(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=" + waiters[2].Id);
        }
        protected void login_ServerClick4(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=" + waiters[3].Id);
        }
        protected void login_ServerClick5(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx?id=" + waiters[4].Id);
        }
    }
}