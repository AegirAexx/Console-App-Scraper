using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace ConsoleAppScraper
{
    class Scraper
    {
        private static string URL = "https://www.arionbanki.is/";

        public static List<string> GetGBP()
        {
            HtmlWeb web = new();
            var doc = web.Load(URL);
            var spanNode = doc.DocumentNode.SelectNodes("//table/tbody/tr/td/span").Where(node => node.GetAttributeValue("class", "").Contains("flag--gbp")).First();
            var rowGBP = spanNode.ParentNode.ParentNode.Descendants();

            List<string> ret = new();

            var i = 0;
            foreach (var row in rowGBP)
            {
                if (i % 2 == 0 && i < 10)
                {
                    ret.Add(row.InnerText.Trim());
                }
                i += 1;
            }

            return ret;
        }
    }
}
