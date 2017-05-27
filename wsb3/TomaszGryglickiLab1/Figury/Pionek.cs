using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGryglickiLab1.Figury
{
    class Pionek
    {
        string[] lis = new string[2];

        public int liczbaFigur()
        {
            lis[0] = "Wieza";
            lis[1] = "Skoczek";

            return lis.Length;
        }

        public string nazwa = "Wieza";

        //new3
        public delegate void CzyRuch(bool success);
        public event CzyRuch messageInfo;

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
                    //new3
                    if (messageInfo != null) messageInfo(false);
                }
                 else
                {
                    //new3
                    if (messageInfo != null) messageInfo(true);
                }
            }

        }
 
    }
}
