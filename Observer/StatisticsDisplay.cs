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

        private float lastHumidity;
        private float avgHumidity;
        private float maxHumidity;
        private float minHumidity;

        private float lastPressure;
        private float avgPressure;
        private float maxPressure;
        private float minPressure;



        public void Update( float temperature,float humidity, float pressure)
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
                avgTemperature = maxTemperature + minTemperature;
                avgTemperature /= 2;
                lastTemperature = temperature;
            }

            if (lastHumidity == 0)
            {
                lastHumidity = humidity;
            }
            if (humidity > maxHumidity)
            {
                maxHumidity = humidity;
            }
            if (minHumidity == 0)
            {
                minHumidity = humidity;
            }
            else if (humidity < minHumidity)
            {
                minHumidity = humidity;
            }
            if (avgHumidity == 0)
            {
                avgHumidity = humidity;
            }
            else
            {
                
                avgHumidity = maxHumidity + minHumidity;
                avgHumidity /= 2;
                lastHumidity = humidity;
            }

            if (lastPressure == 0)
            {
                lastPressure = pressure;
            }
            if (pressure > maxPressure)
            {
                maxPressure = pressure;
            }
            if (minPressure == 0)
            {
                minPressure = pressure;
            }
            else if (pressure < minPressure)
            {
                minPressure = pressure;
            }
            if (avgPressure == 0)
            {
                avgPressure += pressure;
            }
            else
            {
                avgPressure = maxPressure + minPressure;
                avgPressure = avgPressure / 2;
                lastPressure = pressure;
            }
        }

        public string Display()
        {
            return "Средняя t: " + avgTemperature + " °C \nМаксимальная t: " + maxTemperature + " °C \nМинимальная t: " + minTemperature + " °C \n"
                + "Средняя вл-ть: " + avgHumidity + " % \nМаксимальная вл-ть: " + maxHumidity + " % \nМинимальная вл-ть: " + minHumidity + " % \n"
                + "Среднее дав-е: " + avgPressure + " мм рт.ст. \nМаксимальное дав-е: " + maxPressure + " мм рт.ст. \nМинимальное дав-е: " + minPressure + " мм рт.ст. \n";
        }
    }
}
