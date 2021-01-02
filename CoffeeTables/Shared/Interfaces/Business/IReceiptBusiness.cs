using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IReceiptBusiness
    {
        List<Receipt> GetAllReceipts();
        bool InsertReceipt(Receipt r);
        bool UpdateReceipt(Receipt r);
        bool DeleteReceipt(int Id);
        List<Receipt> GetReceiptsByDate(DateTime date);
        int GetNewReceiptId();
        Receipt GetUnpaidReceiptByTableId(int tableId);
        Receipt GetReceiptById(int id);

    }
}
