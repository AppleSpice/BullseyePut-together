using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    class ScorePrint
    {
        public static void BestScore()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            String[] lines = File.ReadAllLines(path);
            long max = 0;
            long score = 0;
            foreach (String line in lines)
            {
                if (Int64.TryParse(line, out score))
                {
                    if (score > max)
                        max = score;
                }
            }
            Console.WriteLine("Maximum Score is " + max);
            Console.ReadLine();
        }

        public static void lastScore()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            var lastLine = File.ReadLines(path).Last();
            Console.WriteLine($"The last score you got was {lastLine}");
            Console.ReadLine();
        }
    }
}
