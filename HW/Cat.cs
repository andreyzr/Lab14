using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Cat : Animal
    {

        private string name;
        public override string Name { get => name; set => name = value; }

        public Cat(string name)
            : base(name)
        {
            this.name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
