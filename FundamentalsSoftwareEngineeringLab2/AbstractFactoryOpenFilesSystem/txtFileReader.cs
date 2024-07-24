using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    class txtFileReader : ItxtFileReader
    {
        public string ReadFileTxt(string filePath)
        {
            var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
    }
}
