using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.Observer
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void NotifyObservers(String textChanged);
        void RemoveObserver(IObserver o);
    }
}
