using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class WeatherStation
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private int temperature;

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(int temp)
        {
            temperature = temp;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
