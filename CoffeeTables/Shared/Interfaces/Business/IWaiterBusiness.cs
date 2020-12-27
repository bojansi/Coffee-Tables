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
        List<Waiter> getAllWaiters();
        bool insertWaiter(Waiter w);
        bool updateWaiter(Waiter w);
        bool deleteWaiter(int Id);
        Waiter getWaiterById(int id);
        Waiter getWaiterByUserAndPass(string waiterUser, string waiterPass);
        List<Waiter> getLoggedWaiters();


    }
}
