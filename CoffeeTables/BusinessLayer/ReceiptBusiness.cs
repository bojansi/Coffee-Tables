using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ReceiptBusiness:IReceiptBusiness
    {
        private readonly IReceiptRepository receiptRepository;
        public ReceiptBusiness(IReceiptRepository _receiptRepository)
        {
            this.receiptRepository = _receiptRepository;
        }
        public List<Receipt> GetAllReceipts()
        {
            return this.receiptRepository.GetAllReceipts();
        }
        public bool InsertReceipt(Receipt r)
        {
            if(this.receiptRepository.InsertReceipts(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateReceipt(Receipt r)
        {
            if (this.receiptRepository.UpdateReceipt(r) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteReceipt(int Id)
        {
            if (this.receiptRepository.DeleteReceipt(Id) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Receipt> GetReceiptsByDate(DateTime date)
        {
            return this.receiptRepository.GetAllReceipts().Where(r => String.Format("{0:d/M/yyyy}", r.Date).Equals(String.Format("{0:d/M/yyyy}", date))).ToList();
        }

        public int GetNewReceiptId()
        {
            return this.receiptRepository.GetNewReceiptId();
        }

        public Receipt GetUnpaidReceiptByTableId(int tableId)
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
        public Receipt GetReceiptById(int id)
        {
            return this.receiptRepository.GetAllReceipts().FirstOrDefault(r => r.Id == id);
        }
    }
}
