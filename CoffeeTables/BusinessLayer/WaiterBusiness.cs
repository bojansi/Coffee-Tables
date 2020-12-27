using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class WaiterBusiness
    {
        private readonly WaiterRepository waiterRepository;
        public WaiterBusiness()
        {
            this.waiterRepository = new WaiterRepository();
        }

        public List<Waiter> getAllWaiters()
        {
            return this.waiterRepository.GetAllWaiters();
        }

        public bool insertWaiter(Waiter w)
        {
            if(this.waiterRepository.InsertWaiter(w) > 0)
            {
                return true;
            }
            return false;
        }
        public bool updateWaiter(Waiter w)
        {
            if (this.waiterRepository.UpdateWaiter(w) > 0)
            {
                return true;
            }
            return false;
        }
        public bool deleteWaiter(int Id)
        {
            if (this.waiterRepository.DeleteWaiter(Id) > 0)
            {
                return true;
            }
            return false;
        }

        public Waiter getWaiterById(int id)
        {
            return this.waiterRepository.GetAllWaiters().FirstOrDefault(w => w.Id == id);
        }

        public Waiter getWaiterByUserAndPass(string waiterUser, string waiterPass)
        {
            return this.waiterRepository.GetAllWaiters().FirstOrDefault(w => w.Username == waiterUser && w.Password == waiterPass);
        }
        public List<Waiter> getLoggedWaiters()
        {
            return this.waiterRepository.GetAllWaiters().Where(w => w.Logged == true).ToList();
        }
    }
}
