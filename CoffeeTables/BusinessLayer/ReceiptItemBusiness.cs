﻿using DataLayer;
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
    public class ReceiptItemBusiness:IReceiptItemBusiness
    {
        private readonly IReceiptItemRepository receiptItemRepository;
        public ReceiptItemBusiness(IReceiptItemRepository _receiptItemRepository)
        {
            this.receiptItemRepository = _receiptItemRepository;
        }
        public List<ReceiptItem> getAllReceiptItems()
        {
            return this.receiptItemRepository.GetAllReceiptItems();
        }
        public bool insertReceiptItem(ReceiptItem r)
        {
            if (this.receiptItemRepository.InsertReceiptItem(r) > 0)
            {
                return true;
            }
            return false;
        }
        public bool updateReceiptItem(ReceiptItem r)
        {
            if (this.receiptItemRepository.UpdateReceiptItem(r) > 0)
            {
                return true;
            }
            return false;
        }
        public bool deleteReceiptItemById(int rId, int pId)
        {
            if (this.receiptItemRepository.DeleteReceiptItemById(rId,pId) > 0)
            {
                return true;
            }
            return false;
        }
        public List<ReceiptItem> getReceiptItemByReceiptId(int receiptId)
        {
            return this.receiptItemRepository.GetAllReceiptItems().Where(r => r.ReceiptId == receiptId).ToList();
        }
    }
}
