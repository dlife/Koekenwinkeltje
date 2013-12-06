using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koekenwinkeltje
{
    class Calculate
    {
        private bool _special;
        private bool _gamble;
        private double _aantal;
        private double _btw;
        private double _eenheid;

        private enum Reduction
        { 
            big = 10,
            tenthCustomer = 5,
            goodGamble = 15

        }

        public bool special { get {return _special;} set { _special = value; } }
        public double aantal { get { return _aantal; } set { _aantal = value; } }
        public double btw { get { return _btw; } set { _btw = value; } }
        public double eenheid { get { return _eenheid; } set { _eenheid = value; } }

        public Calculate(bool special, double aantal, double btw, string sEenheid, bool gamble)
        {
            _special = special;
            _aantal = aantal;
            _btw = btw;
            _eenheid = Products.producten[sEenheid];
            _gamble = gamble;
        }

        public string GetResult(string soort)
        {
            string result;
            double calcResult = _aantal * _eenheid;
            result = "De totaalprijs voor " + _aantal + " koekje(s) van het type " + soort + " (eenheidsprijs: €" + _eenheid + ") + 21% BTW";
            if (calcResult > 25)
            {
                calcResult = calcResult - ((calcResult * (double)Reduction.big)/100);
                result += " met 10 % korting";
            }
            if (_special)
            {
                calcResult = calcResult - ((calcResult * (double)Reduction.tenthCustomer)/100);
                result += " en nog een extra 5% korting (elke 10e klant)";
            }
            if (_gamble)
            {
                calcResult = calcResult - ((calcResult * (double)Reduction.goodGamble)/100);
                result += " en nog een extra korting van 15% (goed gegokt!!)";
            }
            result += " bedraagt €" + calcResult + ".";

            return result;
        }

    }
}
