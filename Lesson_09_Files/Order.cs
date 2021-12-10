using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_09_Files
{
    public class Order
    {
        public Order()
        {
            Products = new List<Product>();
        }

        public int ID { get; set; }

        public DateTime Date { get; set; }

        public decimal Total
        {
            get
            {
                return Products.Sum(p => p.Price);
            }
        }

        public List<Product> Products { get; set; }
    }
}