using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.interfaces
{
    interface ITextStatisticProvider
    {
        Dictionary<string, string> CalcStat();

    }
}
