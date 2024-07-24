using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    class FileReadersCreator : IFileReader
    {
        public  IdatFileReader createDatFileReader()
        {
            return new DatFileReader();
        }

        public IhtmlFileReader createHtmlFileReader()
        {
            return new HtmlFileReader();
        }

        public  ItxtFileReader createTxtFileReader()
        {
            return new txtFileReader();
        }
    }
}
