using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles
{
    class txtFileSaver : FileSaver
    {
        public override void save(SaveFileDialog SFD,String text)
        {
            StreamWriter SW;
            SW = new StreamWriter(SFD.FileName);
            SW.Write(text);
            SW.Close();
        }
    }
}
