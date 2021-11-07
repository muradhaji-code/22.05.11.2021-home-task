using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._11._2021_home_task
{
    class Milk : Product
    {
        public double Volume { get; set; }
        public double FatRate { get; set; }

        private Milk(string Name, double Price, int Count, double Volume, double FatRate)
        {

            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
            this.Volume = Volume;
            this.FatRate = FatRate;
        }

        public static Milk CreateInstance(string Name, double Price, int Count, double Volume, double FatRate)
        {
            if (Name.Length == 0)
            {
                Console.WriteLine("\nProduct name can not be blank!");
                return null;
            }
            return new Milk(Name, Price, Count, Volume, FatRate);
        }
    }
}
