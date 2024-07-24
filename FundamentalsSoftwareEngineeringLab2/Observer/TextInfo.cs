using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.Observer
{
    class TextInfo : IObserver
    {
        public void Update(String txt)
        {
            int amountSymbolsInAuthorsPage = 1800;
            String message = txt.Length/amountSymbolsInAuthorsPage+" authors pages";
             MessageBox.Show(
        message, 
        "Сообщение", 
        MessageBoxButtons.OK, 
        MessageBoxIcon.Information, 
        MessageBoxDefaultButton.Button1, 
        MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
