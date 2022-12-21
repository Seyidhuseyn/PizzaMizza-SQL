using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Models
{
    internal class PizzaSizes
    {
        public int id { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int PizzaId { get; set; }
        public int SizeId { get; set; }
    }
}
