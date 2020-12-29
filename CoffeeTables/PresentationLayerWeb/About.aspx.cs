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
    public partial class About : Page
    {
        public string USER = null;
        static int indexSelectedTable = 0;

        private readonly IProductBusiness productBusiness;
        private readonly IReceiptBusiness receiptBusiness;
        private readonly IReceiptItemBusiness receiptItemBusiness;
        private readonly IWaiterBusiness waiterBusiness;
        private readonly ITableBusiness tableBusiness;
        public About(IProductBusiness _productBusiness, IReceiptBusiness _receiptBusiness, IReceiptItemBusiness _receiptItemBusiness, IWaiterBusiness _waiterBusiness, ITableBusiness _tableBusiness)
        {
            this.productBusiness = _productBusiness;
            this.receiptBusiness = _receiptBusiness;
            this.receiptItemBusiness = _receiptItemBusiness;
            this.tableBusiness = _tableBusiness;
            this.waiterBusiness = _waiterBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            String iduser = Request.QueryString["id"];
            USER = iduser;

            List<Receipt> todaysList = receiptBusiness.getReceiptByTodayDate(DateTime.Now);
            List<Receipt> AllList = receiptBusiness.getAllReceipts();

            decimal sumAll = AllList.Sum(s => s.Total);
            allValue.InnerText = sumAll.ToString();

            decimal sumToday = todaysList.Sum(r => r.Total);
            todayValue.InnerText = sumToday.ToString();

            int countToday = todaysList.Count();
            todayValueCount.InnerText = countToday.ToString();
            int countAll = AllList.Count();
            allValueCount.InnerText = countAll.ToString();


            List<Table> tables = tableBusiness.getAllTables();
            t1.Attributes.Add("class", (tables[0].Taken) ? "full table" : "empty table");
            t2.Attributes.Add("class", (tables[1].Taken) ? "full table" : "empty table");
            t3.Attributes.Add("class", (tables[2].Taken) ? "full table" : "empty table");
            t4.Attributes.Add("class", (tables[3].Taken) ? "full table" : "empty table");
            t5.Attributes.Add("class", (tables[4].Taken) ? "full table" : "empty table");

            
        }
        int ReceiptCountByTableToday(int id)
        {
            List<Receipt> todaysList = receiptBusiness.getReceiptByTodayDate(DateTime.Now);
            int k = 0;

            for (int i = 0; i < todaysList.Count(); i++)
            {
                if (todaysList[i].TableId == id)
                {
                    k++;
                }
            }
            return k;
        }
        decimal ReceiptSumByTableToday(int id)
        {
            List<Receipt> todaysList = receiptBusiness.getReceiptByTodayDate(DateTime.Now);
            decimal k = 0;
            for (int i = 0; i < todaysList.Count(); i++)
            {
                if (todaysList[i].TableId == id)
                {
                    k = k + todaysList[i].Total;
                }
            }
            return k;
        }
        decimal ReceiptSumTableAll(int id)
        {
            List<Receipt> AllList = receiptBusiness.getAllReceipts();
            decimal k = 0;
            for (int i = 0; i < AllList.Count(); i++)
            {
                if (AllList[i].TableId == id)
                {
                    k = k + AllList[i].Total;
                }
            }
            return k;
        }
        void getTableData(int id)
        {
            indexSelectedTable = id;

            int tableCount = ReceiptCountByTableToday(indexSelectedTable);
            tableCountValue.InnerText = tableCount.ToString();

            decimal tableSumToday = ReceiptSumByTableToday(indexSelectedTable);
            tableSumTodayValue.InnerText = tableCount.ToString();

            decimal tableSumAll = ReceiptSumTableAll(indexSelectedTable);
            tableSumAllValue.InnerText = tableSumAll.ToString();
        }

        protected void table_ServerClick1(object sender, EventArgs e)
        {

            t1.Attributes.Add("class", "aktivno table");

            //Deleting active status
            t2.Attributes["class"] = t2.Attributes["class"].Replace("aktivno", "").Trim();
            t3.Attributes["class"] = t3.Attributes["class"].Replace("aktivno", "").Trim();
            t4.Attributes["class"] = t4.Attributes["class"].Replace("aktivno", "").Trim();
            t5.Attributes["class"] = t5.Attributes["class"].Replace("aktivno", "").Trim();
            getTableData(1);
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
            getTableData(2);
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
            getTableData(3);
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
            getTableData(4);
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
            getTableData(5);
            heading.InnerText = "Sto br. " + indexSelectedTable.ToString();
        }
    }
}