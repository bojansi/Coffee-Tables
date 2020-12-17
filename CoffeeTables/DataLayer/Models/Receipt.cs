using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Receipt
    {

        public int Id { get; set; }
        public int WaiterId { get; set; }
        public int TableId { get; set; }
        public int Date { get; set; }
        public decimal Cost { get; set; }


        
    }
}
