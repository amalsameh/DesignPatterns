using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ObserverPattern
{

    // Uses the Subject interface to update all Observers

    public class StockGrabber : Subject
    {

        private List<Observer> observers;
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        public StockGrabber()
        {

            // Creates an ArrayList to hold all observers

            observers = new List<Observer>();
        }

        public void register(Observer newObserver)
        {

            // Adds a new observer to the ArrayList

            observers.Add(newObserver);

        }

        public void unregister(Observer deleteObserver)
        {

            // Get the index of the observer to delete

            int observerIndex = observers.IndexOf(deleteObserver);

            // Print out message (Have to increment index to match)

            Console.WriteLine("Observer " + (observerIndex + 1) + " deleted");

            // Removes observer from the ArrayList

            observers.Remove(observers[observerIndex]);
        }

        public void notifyObserver()
        {

            // Cycle through all observers and notifies them of
            // price changes

            foreach (Observer observer in observers)
            {
                observer.update(ibmPrice, aaplPrice, googPrice);
            }
        }

        // Change prices for all stocks and notifies observers of changes

        public void setIBMPrice(double newIBMPrice)
        {

            this.ibmPrice = newIBMPrice;

            notifyObserver();

        }

        public void setAAPLPrice(double newAAPLPrice)
        {

            this.aaplPrice = newAAPLPrice;

            notifyObserver();

        }

        public void setGOOGPrice(double newGOOGPrice)
        {

            this.googPrice = newGOOGPrice;

            notifyObserver();

        }
    }

}
