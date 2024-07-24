using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.Observer
{
    interface IObserver
    {
        void Update(String txt);
    }
}
