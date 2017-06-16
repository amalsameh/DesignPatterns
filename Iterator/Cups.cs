using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Cups : Expression
    {


    public override String gallons(double quantity)
    {
            double result = quantity / 16;
            return result.ToString();
        }

    public override String quarts(double quantity)
    {
            double result = quantity / 4;
            return result.ToString();

        }

        public override String pints(double quantity)
    {
            double result = quantity / 2;
            return result.ToString();

        }

        public override String cups(double quantity)
    {
        return quantity.ToString ();
    }

    public override String tablespoons(double quantity)
    {
            double result = quantity / 16;
            return result.ToString();
    }

}
}
