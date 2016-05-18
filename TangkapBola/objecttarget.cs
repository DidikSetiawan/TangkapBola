using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TangkapBola
{
    class objecttarget:objectgame
    {
        private bool _kena ;
       
        public bool kena
        {
            get
            {
                return _kena;
            }
            set
            {
                _kena = value;
            }
        }

        public objecttarget(int x, int y, int panjang, int tinggi)
        {
            X = x;
            Y = y;
            T = tinggi;
            P = panjang;
            kena = false; 
        }
    }
}