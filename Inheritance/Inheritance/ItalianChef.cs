using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef 
    {
        public void MakeBurger()
        {
            Console.WriteLine("Making Burger");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Making Fish Omelete");
        }
    }
}
