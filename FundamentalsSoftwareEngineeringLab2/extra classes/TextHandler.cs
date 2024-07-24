using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.extra_classes
{
    class TextHandler
    {
        private string text;
        public  TextHandler(string text)
        {
            this.text = text;
        }
        public string handleText()
        {
            deleteTabulation();
            deleteExtraSpace();
            deleteEmptyLines();
            return this.text;
        }
        private void deleteTabulation()
        {
            this.text = text.Replace("\t", String.Empty);
        }
        private void deleteExtraSpace()
        {
            string pattern = "\\s{2,}";
            string target = " ";
            Regex regex = new Regex(pattern);
            this.text =  regex.Replace(this.text, target);
        }
        private void deleteEmptyLines()
        {
            string[] textStrings = this.text.Split('\n');

            List<string> listOfStrings = new List<string>(textStrings);

            listOfStrings.RemoveAll(s => s == "");

            this.text = String.Join("\n", textStrings);
        }
    }
}
