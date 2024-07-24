using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    interface IdatFileReader
    {
        String ReadDatFile(String filePath);
    }
}
