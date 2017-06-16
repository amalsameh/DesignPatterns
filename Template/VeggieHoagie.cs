using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class VeggieHoagie : Hoagie
    {

        String []
        veggiesUsed = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String []
        condimentsUsed = { "Oil", "Vinegar" };

        bool customerWantsMeat() { return false; }
        bool customerWantsCheese() { return false; }


    public override void addVegetables()
    {

        Console.WriteLine("Adding the Vegetables: ");

        foreach (String vegetable in veggiesUsed)
        {

            Console.WriteLine(vegetable + " ");

        }

    }

    public override void addCondiments()
    {

        Console.WriteLine("Adding the Condiments: ");

        foreach (String condiment in condimentsUsed)
        {

            Console.WriteLine(condiment + " ");

        }

    }

        public override void addMeat() { }

        public override void addCheese() { }


}
}
