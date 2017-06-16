using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Bird:Animal
    {
        // The constructor initializes all objects

        public Bird()
        {

            setSound("Tweet");

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal

            flyingType = new ItFlys();

        }
    }
}
