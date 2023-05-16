using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Рэкс");
            dog.ShowInfo();
            Cat cat = new Cat("Васька");
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}
