using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    class PlayerName
    {
        public static string playerName1;
        public static void playerName()
        {
            Console.WriteLine("Please enter your name");
            playerName1 = Console.ReadLine(); // need to get name with the score
            Console.WriteLine($"Hello {playerName1}. Nice to meet you.");
        }
    }
}
