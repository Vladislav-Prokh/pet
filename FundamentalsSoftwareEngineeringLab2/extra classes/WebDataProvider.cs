using FundamentalsSoftwareEngineeringLab2.interfaces;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsSoftwareEngineeringLab2.extra_classes
{
    class WebDataProvider : IDataProvider<List<String>>
    {

        public List<String> getData(int amountOfRecords, string url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string document = reader.ReadToEnd();

            var headlinesData = Regex.Matches(document,@"(?<=<h4><a\b[^>]*>)(.*?)(?=<\/a><\/h4>)")
                .Cast<Match>()
                .Select(m=>m.Groups[1].Value)
                .ToList();
            RemoveTagsFromListofStrings(headlinesData);

            List<string> listAnnotation = new List<string>();
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(document);
            var parsedDivs = htmlDoc.DocumentNode.SelectNodes("//div[contains(@class,'text')]");
    
            foreach(HtmlNode div in parsedDivs)
            {
                listAnnotation.Add(div.InnerText);
            }

            listAnnotation = RemoveTagsFromListofStrings(listAnnotation);

            List<string> listResult = new List<string>();
            for (int i = 0;i < amountOfRecords; i++)
            {
                listResult.Add(headlinesData[i] + '\n' + listAnnotation[i]);
            }

            data.Close();
            reader.Close();

            return listResult;
        }

        private List<string> RemoveTagsFromListofStrings(List<string> strings)
        {
            Regex regex = new Regex("<strong>|</strong>|&nbsp;|&raquo;|&laquo;|<p>|</p>|\r|\n|&ndash;");
            List<string> buffer = new List<string>(strings.Count);
            foreach (string str in strings)
            {
                var substrings = regex.Split(str).ToList();
                buffer.Add(String.Join("", substrings));

            }
            return buffer;
        }
  
      
    }
}
