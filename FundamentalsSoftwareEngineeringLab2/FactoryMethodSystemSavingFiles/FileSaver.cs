using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles
{
    abstract class FileSaver
    {
        abstract public void save(SaveFileDialog SFD,String text);
    }
}
