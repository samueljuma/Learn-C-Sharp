using System;

namespace Inheritance
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            ItalianChef italianChef = new ItalianChef();
            chef.MakeChicken();
            italianChef.MakeBurger();

            chef.MakeSpecialDish();
            italianChef.MakeSpecialDish();
        }
    }
}