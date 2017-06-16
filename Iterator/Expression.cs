using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Expression
    {

        public abstract String gallons(double quantity);
        public abstract String quarts(double quantity);
        public abstract String pints(double quantity);
        public abstract String cups(double quantity);
        public abstract String tablespoons(double quantity);

    }
}
