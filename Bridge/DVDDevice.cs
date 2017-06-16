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

    public class DVDDevice : EntertainmentDevice
    {


    public DVDDevice(int newDeviceState, int newMaxSetting)
    {

        base .deviceState = newDeviceState;

        base.maxSetting = newMaxSetting;

    }

    public override void buttonFivePressed()
    {

        Console.WriteLine("DVD Skips to Chapter");

        deviceState--;

    }

    public override void buttonSixPressed()
    {

        Console.WriteLine("DVD Skips to Next Chapter");

        deviceState++;

    }


}
}
