using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Table
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool Taken { get; set; }
        public string Description { get; set; }
    }
}
