using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    class HotColdDificulty
    {

        public static double difficulty;
        public static bool gameOver = true;
        public static void Difficulty()
        {
            int easy = 25;
            int medium = 12;
            int hard = 5;
            int extreme = 1;

            //choose difficulty
            Console.WriteLine("Choose a difficulty. 1:Easy 2:Medium 3:Hard 4:Extreme. Please enter a number");
            int difChoice = Convert.ToInt32(Console.ReadLine());

            //sets difficulty
            switch (difChoice)
            {
                case 1:
                    difficulty = easy;
                    break;
                case 2:
                    difficulty = medium;
                    break;
                case 3:
                    difficulty = hard;
                    break;
                case 4:
                    difficulty = extreme;
                    break;
            }
        }

        public static void HotCold()
        {
            
            double distance = Math.Floor(Math.Sqrt(Math.Pow(RandomNumAndCursorTracking.userX - RandomNumAndCursorTracking.randomX, 2) + Math.Pow(RandomNumAndCursorTracking.userY - RandomNumAndCursorTracking.randomY, 2)));
            
            if (distance > 400)
            {
                Console.WriteLine("Frozen");
                TimerAndDifficulty.timer();
            }
            else if (distance >= 200)
            {
                Console.WriteLine("Ice Cold");
                TimerAndDifficulty.timer();
            }
            else if (distance >= 100)
            {
                Console.WriteLine("Cold");
                TimerAndDifficulty.timer();
            }
            else if (distance >= 50)
            {
                Console.WriteLine("Warm");
                TimerAndDifficulty.timer();
            }
            else if (distance >= 30)
            {
                Console.WriteLine("On Fire");
                TimerAndDifficulty.timer();
            }
            else if (distance > difficulty)
            {
                targetHit.HitWin();
                Console.WriteLine("Hit");
            }
        }
    }
}
