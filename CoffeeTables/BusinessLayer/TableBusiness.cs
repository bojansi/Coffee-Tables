using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace BusinessLayer
{
    public class TableBusiness
    {
        private readonly TableRepository tableRepository;
        public TableBusiness()
        {
            this.tableRepository = new TableRepository();
        }

        public List<Table> getAllTables()
        {
            return this.tableRepository.GetAllTables();
        }

        public int getTableById(int Id)
        {
            //return this.tableRepository.GetAllTables().FirstOrDefault(t => t.Id == id);
            return 0;
        }

        public bool updateTable(Table t)
        {
            if (this.tableRepository.UpdateTable(t) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
