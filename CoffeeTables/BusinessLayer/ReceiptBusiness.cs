using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReceiptBusiness
    {
        private readonly ReceiptRepository receiptRepository;
        public ReceiptBusiness()
        {
            this.receiptRepository = new ReceiptRepository();
        }
        public List<Receipt> getAllReceipts()
        {
            return this.receiptRepository.GetAllReceipts();
        }
        public bool insertReceipt(Receipt r)
        {
            if(this.receiptRepository.InsertReceipts(r) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Receipt> getReceiptByTodayDate(DateTime date)
        {
            return this.receiptRepository.GetAllReceipts().Where(r => r.Date == date).ToList();
        }
    }
}
