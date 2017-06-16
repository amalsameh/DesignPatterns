using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    // A Template Method Pattern contains a method that provides
    // the steps of the algorithm. It allows subclasses to override 
    // some of the methods

    public abstract class Hoagie
    {

        bool _afterFirstCondiment = false;

        // This is the Template Method
        // Declare this method final to keep subclasses from
        // changing the algorithm

        public  sealed override   void makeSandwich()
        {

            cutBun();

            if (customerWantsMeat())
            {

                addMeat();

                // Here to handle new lines for spacing
                _afterFirstCondiment = true;

            }

            if (customerWantsCheese())
            {

                if (_afterFirstCondiment) { Console.WriteLine("\n"); }

                addCheese();

                _afterFirstCondiment = true;

            }

            if (customerWantsVegetables())
            {

                if (_afterFirstCondiment) { Console.WriteLine("\n"); }

                addVegetables();

                _afterFirstCondiment = true;

            }

            if (customerWantsCondiments())
            {

                if (_afterFirstCondiment) { Console.WriteLine("\n"); }

                addCondiments();

                _afterFirstCondiment = true;

            }

            wrapTheHoagie();

        }

        // These methods must be overridden by the extending subclasses

        public abstract void addMeat();
        public abstract void addCheese();
        public abstract void addVegetables();
        public abstract void addCondiments();

        public void cutBun()
        {
            Console.WriteLine("The Hoagie is Cut");
        }

        // These are called hooks
        // If the user wants to override these they can

        // Use abstract methods when you want to force the user
        // to override and use a hook when you want it to be optional

        bool customerWantsMeat() { return true; }
        bool customerWantsCheese() { return true; }
        bool customerWantsVegetables() { return true; }
        bool customerWantsCondiments() { return true; }

        public void wrapTheHoagie()
        {
            Console.WriteLine("\nWrap the Hoagie");
        }

        public void afterFirstCondiment()
        {
            Console.WriteLine("\n");
        }

    }
}
