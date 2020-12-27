using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IWaiterRepository
    {
        List<Waiter> GetAllWaiters();
        int InsertWaiter(Waiter w);
        int UpdateWaiter(Waiter w);
        int DeleteWaiter(int Id);
    }
}
