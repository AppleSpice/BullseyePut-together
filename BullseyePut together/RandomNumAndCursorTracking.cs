using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullseyePut_together
{
    class RandomNumAndCursorTracking
    {
        public static int randomX;
        public static int randomY;
        public static int userX;
        public static int userY;
        public static void randomNum()
        {
            Random r = new Random();
            randomX = r.Next(1, 1920);
            Console.WriteLine($"{randomX}"); // generates Random X coord
                                             // write a WriteLine saying this is "x" coord
            Random n = new Random();
            randomY = n.Next(1, 1080);
            Console.WriteLine($"{randomY}"); // generates a random Y coord
                                             // write a WriteLine saying this is "y" coord
        }

        public static void CursorTracking()
        {
            
            userX = Cursor.Position.X;
            userY = Cursor.Position.Y;
            //Console.WriteLine($"{userX},{userY}");
            HotColdDificulty.HotCold();
                
            
        }
    }
}
