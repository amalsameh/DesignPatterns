using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class SandwichSculptor
    {

        public static void main(String[] args)
        {

            ItalianHoagie cust12Hoagie = new ItalianHoagie();

            cust12Hoagie.makeSandwich();

            Console.WriteLine();

            VeggieHoagie cust13Hoagie = new VeggieHoagie();

            cust13Hoagie.makeSandwich();

        }

    }
}
