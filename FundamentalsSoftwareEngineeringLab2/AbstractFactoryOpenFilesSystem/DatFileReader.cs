using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    class DatFileReader : IdatFileReader
    {
        public string ReadDatFile(string filePath)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                string text = reader.ReadString();
                return text;
            }
        }
    }
}
