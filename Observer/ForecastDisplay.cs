using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double temperature;
        private double humidity;
        private double pressure;
        readonly Random rnd = new Random();

        public void Update(float temperatue, float humidity, float pressure)
        {
            this.temperature = temperatue * (rnd.Next(5, 15) / 10.0);
            this.humidity = humidity * (rnd.Next(5, 15) / 10.0);
            this.pressure = pressure * (rnd.Next(10, 12) / 10.0);
        }

        public string Display()
        {
            return "Текущий прогноз: \n" + temperature + " °C градусов\n" + humidity + " % влажности \n" + pressure + " мм рт.ст.";
        }
    }
}
