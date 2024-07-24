using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.interfaces
{
    interface IDataProvider<T> { T getData(int amountOfRecords,string url);}
}
