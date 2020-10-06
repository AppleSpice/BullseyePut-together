using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BullseyePut_together
{
    class PrintScorePlayAgain
    {
        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to go again?");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                
            }
            else if (loop == "n")
            {
                
            }
            else
            {
            }
        }

        public static void OutputScore()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(); // When other sections are being made, this score is for the myData.txt   AKA the key for keeping track of all score given.
                sw.Close();
            }
        }
    }
}
