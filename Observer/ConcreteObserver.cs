using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    public class ConcreteObserver : Observer
    {
        int count = 0;
        public int Count { get { return count; } }
        public void Update(Subject subject)
        {
            count++ ;
        }
    }
}
