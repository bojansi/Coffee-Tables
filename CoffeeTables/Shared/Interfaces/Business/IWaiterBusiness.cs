using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IWaiterBusiness
    {
        List<Waiter> GetAllWaiters();
        bool InsertWaiter(Waiter w);
        bool UpdateWaiter(Waiter w);
        bool DeleteWaiter(int Id);
        Waiter GetWaiterById(int id);
        Waiter GetWaiterByUserAndPass(string waiterUser, string waiterPass);
        List<Waiter> GetLoggedWaiters();


    }
}
