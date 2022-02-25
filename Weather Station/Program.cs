using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData Sub = new WeatherData();

            CurrentConditionsDisplay cd = new CurrentConditionsDisplay();
            StatisticsDisplay sd = new StatisticsDisplay();
            ForecastDisplay fd = new ForecastDisplay();

            Sub.registerObserver(cd);
            Sub.registerObserver(sd);
            Sub.registerObserver(fd);

            Sub.GetTemperature(15);
            Sub.GetPressure(790);
            Sub.GetHumidity(70);
            Sub.MeasurementsChanged();


            Sub.GetPressure(750);
            Sub.GetHumidity(50);
            Sub.GetTemperature(5);
            Sub.MeasurementsChanged();

            Console.WriteLine(cd.Display());
            Console.WriteLine();
            Console.WriteLine(sd.Display());
            Console.WriteLine();
            Console.WriteLine(fd.Display());

            Sub.removeObserver(fd);

            Console.ReadLine();
        }
    }
}
