using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class WeatherDisplay:IObserver
    {
        public void Update(int temperature)
        {
            Console.WriteLine("Temperature updated: " + temperature);
        }
    }
}
