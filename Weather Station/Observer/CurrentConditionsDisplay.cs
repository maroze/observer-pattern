using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;


        public void Update(float temperatue, float humidity, float pressure)
        {
            this.temperature = temperatue;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        public string Display()
        {
           return "Текущие сведения: \n" + this.temperature + " °C градусов \n" + this.humidity + " % влажности\n" + pressure + " мм рт.ст. ";
        }
    }
}
