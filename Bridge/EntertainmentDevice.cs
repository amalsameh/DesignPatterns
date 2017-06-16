using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Implementor
    // With the Bridge Design Pattern you create 2 layers of abstraction
    // In this example I'll have an abstract class representing
    // different types of devices. I also have an abstract class
    // that will represent different types of remote controls

    // This allows me to use an infinite variety of devices and remotes

    public abstract class EntertainmentDevice
    {

        public int deviceState;

        public int maxSetting;

        public int volumeLevel = 0;

        public abstract void buttonFivePressed();

        public abstract void buttonSixPressed();

        public void deviceFeedback()
        {

            if (deviceState > maxSetting || deviceState < 0) { deviceState = 0; }

            Console.WriteLine("On Channel " + deviceState);

        }

        public void buttonSevenPressed()
        {

            volumeLevel++;

            Console.WriteLine("Volume at: " + volumeLevel);

        }

        public void buttonEightPressed()
        {

            volumeLevel--;

            Console.WriteLine("Volume at: " + volumeLevel);

        }

    }
}
