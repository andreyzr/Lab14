using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Антоновка","Кислослаткий","Россия");
            apple.ShowInfo();
            Lemon lemon = new Lemon("Королевский", 1);
            lemon.ShowInfo();
            Console.ReadKey();
        }
    }
}
