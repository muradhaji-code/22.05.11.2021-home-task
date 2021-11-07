using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._11._2021_home_task
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalIncome { get; set; }

        public bool Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
                Console.WriteLine("Product sold.");
                return true;
            }
            Console.WriteLine("Product is not available.");
            return false;
        }
    }
}
