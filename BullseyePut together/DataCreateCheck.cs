using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace BullseyePut_together
{
    class DataCreateCheck
    {
        public static void DataCheck()
        {
            string path = "C:\\Users\\Public\\Documents\\myData.txt";

            if (!File.Exists(path))
            {
                // Create the file if not already made.
                using (FileStream fs = File.Create(path))
                {
                    //puts text in it
                    Byte[] info =
                   new UTF8Encoding(true).GetBytes("N/A");

                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }
            }
            else
            {
               
            }
        }
    }
}
