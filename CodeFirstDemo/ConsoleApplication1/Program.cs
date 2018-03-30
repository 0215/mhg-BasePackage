using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rmb="1";
            //decimal n = decimal.Parse(rmb) / 100;
            string str = "skill_4630.html";
            if (str.Contains("skill"))
            {
                string result = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+", "");
                Console.WriteLine("/Raiders/RaidersDetail/"+result);
            }
       
           // string result = System.Text.RegularExpressions.Regex.Replace(str, @"[^0-9]+", "");
//Console.WriteLine(result);
            Regex skillRg = new Regex(@"skill_{[^0-9]+}.html");
            if (skillRg.IsMatch(str))
            {
                var realPath = skillRg.Replace(str, @"~/Raiders/RaidersDetail/$1");
                Console.WriteLine(realPath);
            }
           
            Console.ReadKey();
        }
    }
}
