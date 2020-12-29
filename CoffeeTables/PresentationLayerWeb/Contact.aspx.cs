using BusinessLayer;
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
using Table = Shared.Models.Table;

namespace PresentationLayerWeb
{
    public partial class Contact : Page
    {
        public string USER = null;
        static int indexSelectedTable = 0;
        
        private readonly IProductBusiness productBusiness;
        private readonly IReceiptBusiness receiptBusiness;
        private readonly IReceiptItemBusiness receiptItemBusiness;
        private readonly IWaiterBusiness waiterBusiness;
        private readonly ITableBusiness tableBusiness;

        private List<Table> tables;


        public Contact(IProductBusiness _productBusiness, IReceiptBusiness _receiptBusiness, IReceiptItemBusiness _receiptItemBusiness, IWaiterBusiness _waiterBusiness, ITableBusiness _tableBusiness)
        {
            this.productBusiness = _productBusiness;
            this.receiptBusiness = _receiptBusiness;
            this.receiptItemBusiness = _receiptItemBusiness;
            this.tableBusiness = _tableBusiness;
            this.waiterBusiness = _waiterBusiness;

            tables = this.tableBusiness.getAllTables();
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {
            String iduser = Request.QueryString["id"];
            USER = iduser;

            if ((Boolean)Session["CheckRefresh"] is true)
            {
                Session["CheckRefresh"] = null;
                Response.Write("Page was refreshed");
                CheckTables();
            }
            else
            { }

            
            CheckTables();
        }
        public void CheckTables() 
        {
            t1.Attributes.Add("class", (receiptBusiness.getUnpaidReceiptByTableId(tables[0].Id) != null) ? "full table" : "empty table");
            t2.Attributes.Add("class", (receiptBusiness.getUnpaidReceiptByTableId(tables[1].Id) != null) ? "full table" : "empty table");
            t3.Attributes.Add("class", (receiptBusiness.getUnpaidReceiptByTableId(tables[2].Id) != null) ? "full table" : "empty table");
            t4.Attributes.Add("class", (receiptBusiness.getUnpaidReceiptByTableId(tables[3].Id) != null) ? "full table" : "empty table");
            t5.Attributes.Add("class", (receiptBusiness.getUnpaidReceiptByTableId(tables[4].Id) != null) ? "full table" : "empty table");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Session["CheckRefresh"] = Session["CheckRefresh"] is null ? false : true;
        }

        void getTotalSumOnTable(int id)
        {
            indexSelectedTable = id;
            Receipt a = receiptBusiness.getUnpaidReceiptByTableId(id);
            if(USER == null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                if (a != null)
                {
                    //if there is a receipt
                    decimal totalAmount = a.Total;
                    totalSUM.InnerText = totalAmount.ToString() + " dinara";
                }
                else
                {
                    //if there isn't
                    totalSUM.InnerText = "";
                    totalSUM.InnerText = "Prazan sto!";
                }
            }
        }
        protected void table_ServerClick1(object sender, EventArgs e)
        {
            
            t1.Attributes.Add("class", "aktivno table");
            
            //Deleting active status
            t2.Attributes["class"] = t2.Attributes["class"].Replace("aktivno", "").Trim();
            t3.Attributes["class"] = t3.Attributes["class"].Replace("aktivno", "").Trim();
            t4.Attributes["class"] = t4.Attributes["class"].Replace("aktivno", "").Trim();
            t5.Attributes["class"] = t5.Attributes["class"].Replace("aktivno", "").Trim();
            getTotalSumOnTable(1);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
        protected void table_ServerClick2(object sender, EventArgs e)
        {

            t2.Attributes.Add("class", "aktivno table"); 
            
            //brisanje aktivnog statusa
            t1.Attributes["class"] = t1.Attributes["class"].Replace("aktivno", "").Trim();
            t3.Attributes["class"] = t3.Attributes["class"].Replace("aktivno", "").Trim();
            t4.Attributes["class"] = t4.Attributes["class"].Replace("aktivno", "").Trim();
            t5.Attributes["class"] = t5.Attributes["class"].Replace("aktivno", "").Trim();
            getTotalSumOnTable(2);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
        protected void table_ServerClick3(object sender, EventArgs e)
        {
            t3.Attributes.Add("class", "aktivno table");
            
            //brisanje aktivnog statusa
            t2.Attributes["class"] = t2.Attributes["class"].Replace("aktivno", "").Trim();
            t1.Attributes["class"] = t1.Attributes["class"].Replace("aktivno", "").Trim();
            t4.Attributes["class"] = t4.Attributes["class"].Replace("aktivno", "").Trim();
            t5.Attributes["class"] = t5.Attributes["class"].Replace("aktivno", "").Trim();
            getTotalSumOnTable(3);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
        protected void table_ServerClick4(object sender, EventArgs e)
        {
            t4.Attributes.Add("class", "aktivno table");
            
            //brisanje aktivnog statusa
            t2.Attributes["class"] = t2.Attributes["class"].Replace("aktivno", "").Trim();
            t3.Attributes["class"] = t3.Attributes["class"].Replace("aktivno", "").Trim();
            t1.Attributes["class"] = t1.Attributes["class"].Replace("aktivno", "").Trim();
            t5.Attributes["class"] = t5.Attributes["class"].Replace("aktivno", "").Trim();
            getTotalSumOnTable(4);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
        protected void table_ServerClick5(object sender, EventArgs e)
        {
            t5.Attributes.Add("class", "aktivno table");
            
            //brisanje aktivnog statusa
            t2.Attributes["class"] = t2.Attributes["class"].Replace("aktivno", "").Trim();
            t3.Attributes["class"] = t3.Attributes["class"].Replace("aktivno", "").Trim();
            t4.Attributes["class"] = t4.Attributes["class"].Replace("aktivno", "").Trim();
            t1.Attributes["class"] = t1.Attributes["class"].Replace("aktivno", "").Trim();
            getTotalSumOnTable(5);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
        protected void checkoutBill(object sender, EventArgs e)
        {
            Receipt a = receiptBusiness.getUnpaidReceiptByTableId(indexSelectedTable);            
            if(a != null)
            {
                checkoutConfirm.InnerText = "Placen!";
                a.WaiterId = Convert.ToInt32(USER);
                a.Paid = true;
                receiptBusiness.updateReceipt(a);
                Table t = tableBusiness.getTableById(indexSelectedTable);
                t.Taken = false;
                tableBusiness.updateTable(t);
                Response.Redirect("contact.aspx?id=" + USER);
            }
            else
            {
                checkoutConfirm.InnerText = "Prazan sto!";
            }  
        }
    }
}

