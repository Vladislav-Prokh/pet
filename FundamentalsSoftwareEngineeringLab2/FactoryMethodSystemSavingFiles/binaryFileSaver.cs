using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles
{
    class binaryFileSaver : FileSaver
    {
     
        public override void save(SaveFileDialog SFD, string text)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(SFD.FileName, FileMode.OpenOrCreate)))
            {
                writer.Write(text);
                writer.Close();
            }
        }
    }
}
