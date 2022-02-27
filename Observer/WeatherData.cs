using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class WeatherData : Subject
    {
        private List<Observer> observer;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observer = new List<Observer>();
        }

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

        public void MeasurementsChanged()
        {
            notifyObserver();
        }

        public void SetTemperature(float temperature)
        {
            this.temperature = temperature;
            MeasurementsChanged();
        }
        public void SetHumidity(float humidity)
        {

            this.humidity = humidity;
            MeasurementsChanged();

        }
        public void SetPressure(float pressure)
        {
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
