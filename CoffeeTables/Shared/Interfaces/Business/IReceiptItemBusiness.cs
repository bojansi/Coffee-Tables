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
        List<ReceiptItem> getAllReceiptItems();
        bool insertReceiptItem(ReceiptItem r);
        bool updateReceiptItem(ReceiptItem r);
        bool deleteReceiptItemById(int rId, int pId);
        List<ReceiptItem> getReceiptItemByReceiptId(int receiptId);

    }
}
