using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IReceiptRepository
    {
        List<Receipt> GetAllReceipts();
        int InsertReceipts(Receipt r);
        int UpdateReceipt(Receipt r);
        int DeleteReceipt(int Id);
        int GetNewReceiptId();
    }
}
