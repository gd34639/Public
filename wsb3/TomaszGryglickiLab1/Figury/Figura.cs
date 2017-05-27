using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGryglickiLab1.Figury
{
    abstract class Figura
    {
        public string Nazwa
        {
            get
            {
                return this.GetType().Name;
            }
        }

        public Pozycja pozycja = null;

        protected bool CzyPionowo(Pozycja nowaPozycja)
        {
            return pozycja.Y == nowaPozycja.Y;
        }

        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return pozycja.X == nowaPozycja.X;
        }

    }
}
