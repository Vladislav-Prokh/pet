using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles
{
    class htmlFileSaver : FileSaver
    {

        String htmlFileContent = "<!DOCTYPE html>\n<html>\n<head>\n</head>\n<body>\n{0} </body>\n</html>";
        public override void save(SaveFileDialog SFD, string text)
        {
            List<String> allLines = text.Split('\n').ToList();

            String buffer = "<p>" + allLines[0];

            String paragraph = "    ";
            for(int i = 1;i < allLines.Count; i++)
            {
                if (allLines[i].StartsWith(paragraph))
                {
                    buffer += "</p>\n";

                    if(i!= allLines.Count)
                        buffer += "<p>";
                }
                buffer += allLines[i];
            }
            buffer += "</p>";
            text = String.Format(htmlFileContent,buffer);
            StreamWriter SW;
            SW = new StreamWriter(SFD.FileName);
            SW.Write(text);
            SW.Close();

        }

        private int countParagraphs(String text)
        {
            return 0;
        }
    }
}
