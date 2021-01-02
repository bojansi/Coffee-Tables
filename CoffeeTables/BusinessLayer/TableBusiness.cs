using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;

namespace BusinessLayer
{
    public class TableBusiness:ITableBusiness
    {
        private readonly ITableRepository tableRepository;
        public TableBusiness(ITableRepository _tableRepository)
        {
            this.tableRepository = _tableRepository;
        }

        public List<Table> GetAllTables()
        {
            return this.tableRepository.GetAllTables();
        }

        public Table GetTableById(int Id)
        {
            return this.tableRepository.GetAllTables().FirstOrDefault(t => t.Id == Id);
        }

        public bool UpdateTable(Table t)
        {
            if (this.tableRepository.UpdateTable(t) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
