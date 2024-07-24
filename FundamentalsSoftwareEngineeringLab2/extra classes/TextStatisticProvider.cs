using FundamentalsSoftwareEngineeringLab2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.extra_classes
{
    class TextStatisticProvider : ITextStatisticProvider
    {
        private const int kb = 1024;
        private const int authorsPageInSymbols = 1800;
        private string text;
        private string latinVowels = "aeoui";
        private string latinConsonants = "bcdfghjlmnpqrstvx";
        private string cyrillicVowels = "аоуиіеєїюя";
        private string cyrillicConsonants = "бвгґдеєжзклмнпрстфхцчшщ";  
        public TextStatisticProvider(string text)
        {
            this.text = text;
        }
        public Dictionary<string, string> CalcStat()
        {
            Dictionary<string, string> stats = new Dictionary<string, string>();
            if (String.IsNullOrEmpty(text))
                return stats;

            int bytes = size_Bytes();
            stats["sizeBytes"] = bytes.ToString()+"B";
            float kbytes = size_Bytes() / kb;
            stats["sizeKbytes"] = kbytes.ToString()+"Kb";
            stats["amount of characters"] = AnountOfChars().ToString();
            stats["authorsPages"] = CountAuthorsPages().ToString();
            stats["emptyLines"] = CountEmptyLines().ToString();
            stats["indents"] = CountIntends().ToString();
            stats["amountOfDigits"] = CountDigit().ToString();
            stats["specialSymbols"] = CountSpecialSymbols().ToString();
            stats["punctuationMark"] = CountPunctuationMark().ToString();
            stats["enLetters"] = CountLetters("latin").ToString();
            stats["latinVowels"] = CountFitsByAlphabet(this.latinVowels).ToString();
            stats["latinConsonants"] = CountFitsByAlphabet(this.latinConsonants).ToString();
            stats["cyrillicLetters"] = CountLetters("cyrillic").ToString();
            stats["cyrillicVowels"] = CountFitsByAlphabet(this.cyrillicVowels).ToString();
            stats["cyrillicConsonants"] = CountFitsByAlphabet(this.cyrillicConsonants).ToString();
            stats["keyWordMatches"] = checkIfConsistKeyWords();
            stats["theLongestWords"] = findNmaxLenWords(10);

            return stats;
        }
        private int size_Bytes(){return this.text.Length * sizeof(char);} 
        private int AnountOfChars(){return this.text.Length;}
        private int CountAuthorsPages(){ return this.text.Length / authorsPageInSymbols; }
        private int CountEmptyLines() {
            string[] lines = text.Split('\n');
            int counterEmptyStr = 0;
            
            for(int i = 0;i < lines.Length; i++)
            {
                if (String.IsNullOrEmpty(lines[i]))
                {
                    counterEmptyStr++;
                }
            }

            return counterEmptyStr;
        }
        private int CountIntends()
        {
            string[] lines = text.Split('\n');
            int counterIndents = 0;
            string indent = "    "; 
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(indent))
                {
                    counterIndents++;
                }
            }
            return counterIndents;
        }
        private int CountDigit()
        {
            string patternAllExceptDigit = "\\D{1,}";
            Regex regexAllExceptDigit = new Regex(patternAllExceptDigit);
            string allDigitInText = regexAllExceptDigit.Replace(text, "");
            return allDigitInText.Length;
        }
        private int CountSpecialSymbols()
        {
          string patternSpecialSymbols = "\\@|\"|\\|\\<\\||\\>|\\$|\\%|\\&|\\#|\\/?";
          return  Regex.Matches(text, patternSpecialSymbols).Count-1 ;
        }
        private int CountPunctuationMark()
        {
           string patternPunctuationMark = "\\.|\\,|\\:|\\;|\\!|\\?|\\...|\\-|{\\w*}|\"\\w*\"";
           return Regex.Matches(text, patternPunctuationMark).Count;
        }
        private int CountLetters(string lang)
        { 
            string pattern;
            switch (lang)
            {
                case "latin":
                    pattern = "[A-z]";
                    break;
                case "cyrillic":
                    pattern = "[А-я]";
                    break;
                default:
                    return 0;
            }
            return Regex.Matches(text, pattern).Count;
        }
        private int CountFitsByAlphabet(string alphabet)
        {
            HashSet<char> tableOfElements = new HashSet<char>(alphabet + alphabet.ToUpper());
   
            int result = 0;
            foreach (var c in text)
                if (tableOfElements.Contains(c))
                    result++;
            return result;
        }


        //task2 

        private string patternKeyWords = "break|in|while|default|const|for|public|class";
        private string checkIfConsistKeyWords()
        {
            String textMatches = "";
            Regex regex = new Regex(patternKeyWords);
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    textMatches += match.Value+" ";
            }
            else
                textMatches = "Matches is not found";

            return textMatches;
        }


        //task 3
        private string findNmaxLenWords(int n)
        {
            Dictionary<string, int> wordsLength = new Dictionary<string, int>();

            string[] words = text.Split('.',',',':',';','{','}','[',']','"',' ','(',')');

            foreach (string word in words)
            {
                string currentWord = word.ToLower();

                if (wordsLength.ContainsKey(currentWord))
                    continue;
                else
                    wordsLength.Add(currentWord, currentWord.Length);
            }
        
            var sortedDict = wordsLength.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            string[] longestWords;

            if (sortedDict.Count <= n)
            {
                longestWords = sortedDict.Keys.ToArray();
            }
            else
            {
                string[] keys = sortedDict.Keys.ToArray();
                longestWords = new string[n];
                int indexArr = 0;
                for (int i = keys.Length - n; i < keys.Length; i++)
                {
                    longestWords[indexArr] = keys[i];
                    indexArr++;
                }
            }

            return String.Join(" ",longestWords);
        }

    }
}
