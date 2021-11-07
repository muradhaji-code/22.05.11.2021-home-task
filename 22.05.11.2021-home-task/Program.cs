using ExtensionMethods;
using System;

namespace _22._05._11._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine($"2 ^ 2 = {2.Exponential(2)}");
            //Console.WriteLine($"2 ^ 3 = {2.Exponential(3)}");
            //Console.WriteLine($"2 ^ 4 = {2.Exponential(4)}");
            #endregion

            #region Task 2
            //Student instance1 = new Student();
            //Student instance2 = new Student();
            //Student instance3 = new Student();
            //Student.ShowInstanceCount();
            #endregion

            #region Task 3
            string name;
            int n, count;
            double price, volume, fatRate;
            Console.Write("How many milks dou you want to create? : ");
            n = int.Parse(Console.ReadLine());
            Milk[] milkArr = new Milk[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEnter product data:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Count: ");
                count = int.Parse(Console.ReadLine());
                Console.Write("Volume: ");
                volume = double.Parse(Console.ReadLine());
                Console.Write("FatRate: ");
                fatRate = double.Parse(Console.ReadLine());
                Milk milkInstance = Milk.CreateInstance(name, price, count, volume, fatRate);
                if (milkInstance != null)
                {
                    Console.WriteLine("\nMilk created successfully!");
                    milkArr[i] = milkInstance;
                }
                else
                {
                    Console.WriteLine("\nMilk couldn't create, please try again!");
                    i--;
                }
            }
            Console.WriteLine("\nMilk array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nProduct {i}:");
                Console.WriteLine($"Name: {milkArr[i].Name}");
                Console.WriteLine($"Price: {milkArr[i].Price}");
                Console.WriteLine($"Count: {milkArr[i].Count}");
                Console.WriteLine($"Volume: {milkArr[i].Volume}");
                Console.WriteLine($"Fatrate: {milkArr[i].FatRate}");
            }
            #endregion
        }
    }
}
