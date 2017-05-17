using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGryglickiLab1.Figury
{
    class Pionek
    {
        public string nazwa = "Wieza";

        public void CzyRuchJestMozliwy(string arg0, int arg1, int arg2, int arg3, int arg4)
        {
            // debug Console.WriteLine(arg1+ " "+ arg2 + " " + arg3 + " " + arg4);
            if (arg0 == "Wieza")
            {
                // warunki dla Wiezy X i Y
                if ( 
                    ((arg3 > arg1 & arg4 > arg2) ||
                     (arg3 < arg1 & arg4 < arg2) ||
                     (arg3 < arg1 & arg4 > arg2) ||
                     (arg3 > arg1 & arg4 < arg2)) || 
                     (arg3 < 1 || arg3 > 8) ||
                     (arg4 < 1 || arg4 > 8)
                   )                   
                {
                    Console.WriteLine(".: Ruch jest niemożliwy!");
                }
                else
                    {
                        Console.WriteLine(".: Ruch jest możliwy.");
                    }
            }

        }
    }
}
