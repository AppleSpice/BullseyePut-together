using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullseyePut_together
{
    class targetHit
    {
        public static void HitWin()
        {
            Console.WriteLine($"You won!!!!!!");
            Process.Start("Chrome.exe", "https://www.youtube.com/watch?v=mnpjpdhUNjY");
        }

        public static void HitLoss()
        {
            Console.WriteLine($"You couldn’t hit the broad side of a barn with a bowling ball. Maybe try again.");
            Process.Start("Chrome.exe", "https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
