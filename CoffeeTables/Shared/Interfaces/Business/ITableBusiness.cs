using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface ITableBusiness
    {
        List<Table> GetAllTables();
        Table GetTableById(int Id);
        bool UpdateTable(Table t);

    }
}
