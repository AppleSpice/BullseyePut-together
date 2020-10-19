using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace BullseyePut_together
{
    class PrintScorePlayAgain
    {
        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to go again? y/n");
            string loop = Console.ReadLine();
            if (loop == "y")
            {
                _RunProgram.start();
            }
            else if (loop == "n")
            {
                System.Environment.Exit(0);
            }
        }

        public static void OutputScore()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine($"Name:{PlayerName.playerName1} Difficulty:{TimerAndDifficulty.maxTime} Difficulty:{HotColdDificulty.difficulty} Score:{TimerAndDifficulty.currentTime}"); // When other sections are being made, this score is for the myData.txt   AKA the key for keeping track of all score given.
                sw.Close();
            }
                
            
        }
    }
}

