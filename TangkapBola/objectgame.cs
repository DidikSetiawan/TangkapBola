using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TangkapBola
{
    public class objectgame
    {

        private int _x;
        private int _y;

        private int _panjang;
        private int _tinggi;

        public objectgame()
        {

        }

        public objectgame(int x, int y, int panjang, int tinggi)
        {
            _x = x;
            _y = y;
            _tinggi = tinggi;
            _panjang = panjang; 
        }

        public int X 
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int P 
        {
            get
            {
                return _panjang;
            }
            set
            {
                _panjang = value;
            }
        }

        public int T
        {
            get
            {
                return _tinggi;
            }
            set
            {
                _tinggi = value;
            }
        }

        public int X2
        {
            get
            {
                return _x + _panjang;
            }
        }

        public int Y2
        {
            get
            {
                return _y + _tinggi;
            }
        }
    }
}
