using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    class _RunProgram
    {
        public static void start()
        {
            DataCreateCheck.DataCheck(); //makes sure data.txt is there
            ScorePrint.lastScore();
            PlayerName.playerName(); //Gets and prints player name
            TimerAndDifficulty.Difficulty(); //decide how much time you get
            HotColdDificulty.Difficulty(); //decide how close you have to be
            Console.WriteLine("Hit enter when you are ready to start.");
            Console.ReadLine();
            RandomNumAndCursorTracking.randomNum(); //gets random number
            TimerAndDifficulty.timer(); //starts main part of game

            PrintScorePlayAgain.OutputScore();//sends score to data.txt
            PrintScorePlayAgain.PlayAgain();//asks player to play again

        }
    }
}
