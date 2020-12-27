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
        List<Receipt> getAllReceipts();
        bool insertReceipt(Receipt r);
        bool updateReceipt(Receipt r);
        bool deleteReceipt(int Id);
        List<Receipt> getReceiptByTodayDate(DateTime date);
        int getNewReceiptId();
        Receipt getUnpaidReceiptByTableId(int tableId);
        Receipt getReceiptById(int id);

    }
}
