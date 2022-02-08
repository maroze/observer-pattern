using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class WeatherData : Subject
    {
        private float temperature;
        private float humidity;
        private float pressure;

        private List<Observer> observer = new List<Observer>();
        public void notifyObserver()
        {
            foreach (var obs in observer)
            {
                obs.Update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer obs)
        {
            this.observer.Add(obs);
        }

        public void removeObserver(Observer obs)
        {
            this.observer.Remove(obs);
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }
        float state;
        public float State
        {
            get { return temperature + humidity + pressure; }
            set { temperature = value; humidity = value; pressure = value; measurementsChanged(); }
        }
    }
}
