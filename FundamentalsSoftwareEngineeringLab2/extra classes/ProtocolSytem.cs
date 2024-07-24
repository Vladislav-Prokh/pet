using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.extra_classes
{
    class ProtocolSytem
    {
        private static eventRegistrator eventRegistrator;
        protected ProtocolSytem()
        {
        }
        public static eventRegistrator getInstance(String filePath)
        {
            if (eventRegistrator == null)
                eventRegistrator = new eventRegistrator(filePath);
            return eventRegistrator;
        }
    }
}
