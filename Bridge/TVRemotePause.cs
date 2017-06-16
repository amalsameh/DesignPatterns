using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Refined Abstraction

    // If I decide I want to further extend the remote I can

    public class TVRemotePause : RemoteButton
    {


    public TVRemotePause(EntertainmentDevice newDevice): base(newDevice)
        {
            
    }

    public override void buttonNinePressed()
    {

        Console.WriteLine("TV was Paused");

    }

}
}
