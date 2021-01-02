using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IReceiptItemBusiness
    {
        List<ReceiptItem> GetAllReceiptItems();
        bool InsertReceiptItem(ReceiptItem r);
        bool UpdateReceiptItem(ReceiptItem r);
        bool DeleteReceiptItemById(int rId, int pId);
        List<ReceiptItem> GetReceiptItemByReceiptId(int receiptId);

    }
}
