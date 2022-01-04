using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Chef
    {
        public void MakeChicken() {
            Console.WriteLine("Making Chicken");
        }
        public void MakePasta()
        {
            Console.WriteLine("Making Pasta");
        }

        // the virtaul class make it possible for overrides in child classes 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Making Fries");
        }
    }
}
