using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class ConcreteSubject : Subject
    {
        private List<Observer> observer = new List<Observer>();
        public void notifyObserver()
        {
            foreach (var obs in observer)
            {
                obs.Update(this);
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
        string state;
        public string State
        {
            get { return state; }
            set { state = value; notifyObserver(); }
        }
    }
}
