using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Receipt
    {

        public int Id { get; set; }
        public int WaiterId { get; set; }
        public int TableId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public bool Paid { get; set; }


        
    }
}
