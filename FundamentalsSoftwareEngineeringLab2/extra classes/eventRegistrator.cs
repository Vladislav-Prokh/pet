using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.extra_classes
{
    class eventRegistrator
    {
        private String filePathToReadRefistratedActions;
        public eventRegistrator(String filePath){
            this.filePathToReadRefistratedActions = filePath;
        }
 
        public void registerEventInFile(DateTime time, string operation, int columnPosition, int rowPosition)
        {
            StreamWriter sw = new StreamWriter(filePathToReadRefistratedActions,true);
            String message = time.ToString() + " " + operation + " " + columnPosition + " " +rowPosition;
            sw.WriteLine(message);
            sw.Close();
        }
    }
}
