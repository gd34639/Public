﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGryglickiLab1
{

    //new2
    class Szachownica
    {
        string[] tablica = new string[10];
        public string this[int AP]
        {
            get
            {
                return (string)tablica[AP];
            }

            set
            {
                tablica[AP] = value;
            }

        }
    }
}
