using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    interface IFileReader
    {
         IdatFileReader createDatFileReader();
         ItxtFileReader createTxtFileReader();
         IhtmlFileReader createHtmlFileReader();

    }
}
