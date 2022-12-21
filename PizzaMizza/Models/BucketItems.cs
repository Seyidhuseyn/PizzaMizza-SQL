using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Models
{
    internal class BucketItems
    {
        public int Id { get; set; }
        public decimal SubPrice { get; set; }
        public int Count { get; set; }
        public int PizzaId { get; set; }
        public int BucketsId { get; set; }
    }
}
