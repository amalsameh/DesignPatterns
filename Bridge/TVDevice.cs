using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Concrete Implementor

    // Here is an implementation of the EntertainmentDevice
    // abstract class. I'm specifying what makes it different
    // from other devices

    public class TVDevice : EntertainmentDevice
    {


    public TVDevice(int newDeviceState, int newMaxSetting)
    {

        deviceState = newDeviceState;

        maxSetting = newMaxSetting;

    }

    public override  void buttonFivePressed()
    {

        Console.WriteLine("Channel Down");

        deviceState--;

    }

    public override void buttonSixPressed()
    {

        Console.WriteLine("Channel Up");

        deviceState++;

    }

}
}
