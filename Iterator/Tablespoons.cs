using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Tablespoons : Expression
    {


    public override String gallons(double quantity)
    {

        return (quantity / 256).ToString();
    }

    public override String quarts(double quantity)
    {
        return (quantity / 64).ToString();
    }

    public override String pints(double quantity)
    {
        return (quantity / 32).ToString();
    }

    public override String cups(double quantity)
    {
        return (quantity / 16).ToString();
    }

    public override String tablespoons(double quantity)
    {
        return (quantity).ToString();
    }

}
}
