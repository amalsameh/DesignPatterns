using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // The Observers update method is called when the Subject changes

    public interface Observer
    {

         void update(double ibmPrice, double aaplPrice, double googPrice);

    }
}
