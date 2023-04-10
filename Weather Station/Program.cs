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
            //Создание субъекта
            ConcreteSubject subject = new ConcreteSubject();

            //Создание наблюдателей
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            //Регистрация первого наблюдателя и изменение состояния
            subject.registerObserver(observer1);
            subject.State = "abc";
            Console.WriteLine("Оповещения 1-го наблюдателя: " + observer1.Count);
            Console.WriteLine("Оповещения 2-го наблюдателя: " + observer2.Count);

            //Регистрация второго наблюдателя и изменение состояния
            subject.registerObserver(observer2);
            subject.State = "def";
            Console.WriteLine("Оповещения 1-го наблюдателя: " + observer1.Count);
            Console.WriteLine("Оповещения 2-го наблюдателя: " + observer2.Count);

            //Удаление второго наблюдателя и изменение состояния
            subject.removeObserver(observer2);
            subject.State = "g";
            Console.WriteLine("Оповещения 1-го наблюдателя: " + observer1.Count);
            Console.WriteLine("Оповещения 2-го наблюдателя: " + observer2.Count);


            Console.ReadLine();
        }
    }
}
