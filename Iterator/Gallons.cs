using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Gallons : Expression
    {


    public override String gallons(double quantity)
    {

        return quantity.ToString();
    }

    public override String quarts(double quantity)
    {
        return Double.toString(quantity * 4);
    }

    public override String pints(double quantity)
    {
        return Double.toString(quantity * 8);
    }

    public override String cups(double quantity)
    {
        return Double.toString(quantity * 16);
    }

    public override String tablespoons(double quantity)
    {
        return Double.toString(quantity * 256);
    }

}
}
