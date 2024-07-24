using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.Observer
{
    class TextEventNotifier : IObservable
    {

        private List<IObserver> observers;
       public  TextEventNotifier()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObservers(String txt)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(txt);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
