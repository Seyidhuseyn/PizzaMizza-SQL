using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Models
{
    internal class PizzaIngredents
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public int IngredentsId { get; set; }
    }
}
