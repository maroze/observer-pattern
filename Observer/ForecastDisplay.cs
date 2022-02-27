using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private double temp;
        private double humid;
        private double pres;
        readonly Random rnd = new Random();

        public void Update(float temperatue, float humidity, float pressure)
        {
            this.temp = temperatue * (rnd.Next(5, 20) / 10.0);
            this.pres = pressure * (rnd.Next(9, 12) / 10.0);
            this.humid = humidity * (rnd.Next(7, 15) / 10.0);
            
        }

        public string Display()
        {
            return "Текущий прогноз: \n" + temp + " °C градусов\n" + humid + " % влажности \n" + pres + " мм рт.ст.";
        }
    }
}
