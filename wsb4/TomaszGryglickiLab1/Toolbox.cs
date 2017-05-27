using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGryglickiLab1
{
    sealed class Toolbox
    {
        private static Szachownica szachownica = new Szachownica();
        private Toolbox() { }

        public static Szachownica szachownicaInstance
        {
            get
            {
                return szachownica;
            }
        }
    }
}
