using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._11._2021_home_task
{
    class Student
    {
        private static int instanceCount = 0;

        public Student()
        {
            instanceCount++;
        }

        public static void ShowInstanceCount()
        {
            Console.WriteLine("Instance count: " + instanceCount);
        }
    }
}
