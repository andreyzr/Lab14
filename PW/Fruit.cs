using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    abstract internal class Fruit
    {
        public abstract string Name { get; set; }

        public Fruit(string name)
        {
            Name = name;
        }
        public abstract void GetTaste();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            GetTaste();
        }
    }

    class Apple : Fruit
    {
        string country;
        private string taste;
        private string name;
        public override string Name { get => name; set => name = value; }

        public Apple(string name,string taste, string country)
            : base(name)
        {
            this.taste = taste;
            this.country = country;
        }
        public override void GetTaste()
        {
            Console.WriteLine(taste);
        }
    }
    class Lemon : Fruit
    {
        int level;
        private string name;
        public override string Name { get => name; set => name = value; }

        public Lemon(string name, int level)
            : base(name)
        {
            this.level = level;
        }
        public override void GetTaste()
        {
            Console.WriteLine("Кислый");
        }
    }
}
