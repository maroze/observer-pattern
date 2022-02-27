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
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();

            subject.registerObserver(observer1);
            subject.State = "abc";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);

            subject.registerObserver(observer2);
            subject.State = "def";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);

            subject.removeObserver(observer2);
            subject.State = "g";
            Console.WriteLine(observer1.Count);
            Console.WriteLine(observer2.Count);


            Console.ReadLine();
        }
    }
}
