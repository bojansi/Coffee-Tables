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

        public bool updateReceipt(Receipt r)
        {
            if (this.receiptRepository.UpdateReceipt(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteReceipt(int Id)
        {
            if (this.receiptRepository.DeleteReceipt(Id) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Receipt> getReceiptByTodayDate(DateTime date)
        {
            return this.receiptRepository.GetAllReceipts().Where(r => r.Date == date).ToList();
        }

        public int getNewReceiptId()
        {
            return this.receiptRepository.GetNewReceiptId();
        }

        public Receipt getUnpaidReceiptByTableId(int tableId)
        {
            return this.receiptRepository.GetAllReceipts().FirstOrDefault(r =>
            {
                if (r.TableId == tableId && r.Paid == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }
        public Receipt getReceiptById(int id)
        {
            return this.receiptRepository.GetAllReceipts().FirstOrDefault(r => r.Id == id);
        }
    }
}
