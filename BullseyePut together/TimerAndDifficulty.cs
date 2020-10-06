using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    public class TimerAndDifficulty
    {
        public static int currentTime = 0;
        public static int maxTime = 20000;
        public static void Difficulty()
        {
           
            int sloth = 400;
            int giantTurtle = 200;
            int greenIguana = 80;
            int cheetah = 40;
            int peregrineFalcon = 20;

            Console.WriteLine("Choose a time difficulty 1:Sloth 2:Giant Turtle 3:Green Iguana 4:Cheetah 5:Peregrine Falcon. Please enter the number.");
            int choiceTimer = Convert.ToInt32(Console.ReadLine());

            switch (choiceTimer)
            {
                case 1:
                    maxTime = sloth;
                    break;
                case 2:
                    maxTime = giantTurtle;
                    break;
                case 3:
                    maxTime = greenIguana;
                    break;
                case 4:
                    maxTime = cheetah;
                    break;
                case 5:
                    maxTime = peregrineFalcon;
                    break;
    
            }
           
        }

        public static void timer()
        {
            Console.WriteLine($"{currentTime}");
            Thread.Sleep(500);
            currentTime++;

            if(currentTime >= maxTime)
            {
                targetHit.HitLoss();
            }

            RandomNumAndCursorTracking.CursorTracking();
            
        }
    }
}
