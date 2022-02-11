using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class StatisticsDisplay : Observer, DisplayElement
    {
        private float lastTemperature;
        private float avgTemperature;
        private float maxTemperature;
        private float minTemperature;

        private float lasthumidity;
        private float avghumidity;
        private float maxhumidity;
        private float minhumidity;

        private float lastpressure;
        private float avgpressure;
        private float maxpressure;
        private float minpressure;



        public void Update(float temperature, float humidity, float pressure)
        {

            if (lastTemperature == 0)
            {
                lastTemperature = temperature;
            }
            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }
            if (minTemperature == 0)
            {
                minTemperature = temperature;
            }
            else if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }
            if (avgTemperature == 0)
            {
                avgTemperature = temperature;
            }
            else
            {
                avgTemperature = temperature + lastTemperature;
                avgTemperature /= 2;
                lastTemperature = temperature;
            }

            if (lasthumidity == 0)
            {
                lasthumidity = humidity;
            }
            if (humidity > maxhumidity)
            {
                maxhumidity = humidity;
            }
            if (minhumidity == 0)
            {
                minhumidity = humidity;
            }
            else if (humidity < minhumidity)
            {
                minhumidity = humidity;
            }
            if (avghumidity == 0)
            {
                avghumidity = humidity;
            }
            else
            {
                avghumidity = humidity + lasthumidity;
                avghumidity /= 2;
                lasthumidity = humidity;
            }

            if (lastpressure == 0)
            {
                lastpressure = pressure;
            }
            if (pressure > maxpressure)
            {
                maxpressure = pressure;
            }
            if (minpressure == 0)
            {
                minpressure = pressure;
            }
            else if (pressure < minpressure)
            {
                minpressure = pressure;
            }
            if (avgpressure == 0)
            {
                avgpressure = pressure;
            }
            else
            {
                avgpressure = pressure + lastpressure;
                avgpressure /= 2;
                lastpressure = pressure;
            }
        }
        public string Display()
        {
            return "Средняя t: " + avgTemperature + " °C \nМаксимальная t: " + maxTemperature + " °C \nМинимальная t: " + minTemperature + " °C \n"
                + "Средняя вл-ть: " + avghumidity + " % \nМаксимальная вл-ть: " + maxhumidity + " % \nМинимальная вл-ть: " + minhumidity + " % \n"
                + "Среднее дав-е: " + avgpressure + " мм рт.ст. \nМаксимальное дав-е: " + maxpressure + " мм рт.ст. \nМинимальное дав-е: " + minpressure + " мм рт.ст. \n";
        }
    }
}
