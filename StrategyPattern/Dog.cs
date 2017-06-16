using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Dog :Animal
    {
        public void digHole()
        {
Console .WriteLine("Dug a hole");
        }

        public Dog()
        {
            setSound("Bark");

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal

            flyingType = new CantFly();

        }

        /* BAD
        * You could override the fly method, but we are breaking
        * the rule that we need to abstract what is different to 
        * the subclasses
        * 
        public void fly(){

            Console.WriteLine("I can't fly");

        }
        */
    }
}
