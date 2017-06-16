using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TestTheRemote
    {

        public static void main(String[] args)
        {

            RemoteButton theTV = new TVRemoteMute(new TVDevice(1, 200));

            RemoteButton theTV2 = new TVRemotePause(new TVDevice(1, 200));

            // HOMEWORK --------------

            RemoteButton theDVD = new DVDRemote(new DVDDevice(1, 14));

            // -----------------------

            Console.WriteLine("Test TV with Mute");

            theTV.buttonFivePressed();
            theTV.buttonSixPressed();
            theTV.buttonNinePressed();

            Console.WriteLine("\nTest TV with Pause");

            theTV2.buttonFivePressed();
            theTV2.buttonSixPressed();
            theTV2.buttonNinePressed();
            theTV2.deviceFeedback();

            // HOMEWORK

            Console.WriteLine("\nTest DVD");

            theDVD.buttonFivePressed();
            theDVD.buttonSixPressed();
            theDVD.buttonNinePressed();
            theDVD.buttonNinePressed();

        }

    }
}
