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

            Sub.SetTemperature(15);
            Sub.SetPressure(790);         
            Sub.SetHumidity(70);

            Console.WriteLine(cd.Display());
            Console.WriteLine();
            Console.WriteLine(sd.Display());
            Console.WriteLine();
            Console.WriteLine(fd.Display());
            Console.WriteLine();

            Sub.SetTemperature(5);
            Sub.SetPressure(760); 
            Sub.SetHumidity(50);
            
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
