using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem
{
    class HtmlFileReader : IhtmlFileReader
    {
        public string ReadHtmlFile(string filePath)
        {
            var sr = new StreamReader(filePath);
            String textOfFile = sr.ReadToEnd();
            String[] splitedHtml = textOfFile.Split(new char [2]{ '<','>'});
            String[] tagsToDelete = new string[] { "/p", "head", "/head", "body", "/body", "!DOCTYPE html", "html", "/html" ,"/"};
            String indent = "<br";
            String paragraph = "<p";
            textOfFile.Replace(indent, "\n");
            textOfFile.Replace(paragraph, "    ");
            
            for(int i = 0;i< splitedHtml.Length; i++)
            {
                foreach(String tag in tagsToDelete)
                {
                  splitedHtml[i]=splitedHtml[i].Replace(tag, "");
                    
                }

                splitedHtml[i] = splitedHtml[i].Replace("br", "\n");
                splitedHtml[i] = splitedHtml[i].Replace("p", "    ");
            }

            splitedHtml = splitedHtml.Where(x => !x.Equals("")).ToArray();
            return String.Join(" ",splitedHtml);
        }
    }
}
