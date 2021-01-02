using DataLayer;
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
    public class WaiterBusiness:IWaiterBusiness
    {

        private readonly IWaiterRepository waiterRepository;
        public WaiterBusiness(IWaiterRepository _waiterRepository)
        {
            this.waiterRepository = _waiterRepository;
        }

        public List<Waiter> GetAllWaiters()
        {
            return this.waiterRepository.GetAllWaiters();
        }

        public bool InsertWaiter(Waiter w)
        {
            if(this.waiterRepository.InsertWaiter(w) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateWaiter(Waiter w)
        {
            if (this.waiterRepository.UpdateWaiter(w) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteWaiter(int Id)
        {
            if (this.waiterRepository.DeleteWaiter(Id) > 0)
            {
                return true;
            }
            return false;
        }

        public Waiter GetWaiterById(int id)
        {
            return this.waiterRepository.GetAllWaiters().FirstOrDefault(w => w.Id == id);
        }

        public Waiter GetWaiterByUserAndPass(string waiterUser, string waiterPass)
        {
            return this.waiterRepository.GetAllWaiters().FirstOrDefault(w => w.Username == waiterUser && w.Password == waiterPass);
        }
        public List<Waiter> GetLoggedWaiters()
        {
            return this.waiterRepository.GetAllWaiters().Where(w => w.Logged == true).ToList();
        }
    }
}
