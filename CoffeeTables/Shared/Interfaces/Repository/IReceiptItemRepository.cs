using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IReceiptItemRepository
    {
        List<ReceiptItem> GetAllReceiptItems();
        int InsertReceiptItem(ReceiptItem r);
        int UpdateReceiptItem(ReceiptItem r);
        int DeleteReceiptItemById(int rId, int pId);
    }
}
