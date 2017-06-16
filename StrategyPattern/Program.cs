using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine("Dog: " + sparky.tryToFly());

            Console.WriteLine("Bird: " + tweety.tryToFly());

            // This allows dynamic changes for flyingType

            sparky.setFlyingAbility(new ItFlys());

            Console.WriteLine("Dog: " + sparky.tryToFly());
            Console.ReadLine();

        }
    }
}
