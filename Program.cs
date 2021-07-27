using System;
using System.Linq;

namespace ConsoleAppScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var gbp = Scraper.GetGBP();

            foreach (var x in gbp)
            {
                Console.WriteLine(x);
            }

        }
    }
}
