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
        private Decimal _aantal;
        private Decimal _btw;
        private Decimal _eenheid;

        private enum Reduction
        { 
            big = 10,
            tenthCustomer = 5,
            goodGamble = 15
        }

        public bool special { get {return _special;} set { _special = value; } }
        public bool gamble { get { return _gamble; } set { _gamble = value; } }
        public Decimal aantal { get { return _aantal; } set { _aantal = value; } }
        public Decimal btw { get { return _btw; } set { _btw = value; } }
        public Decimal eenheid { get { return _eenheid; } set { _eenheid = value; } }

        public Calculate(){}

        public string GetResult(string soort)
        {
            string result;
            Decimal calcResult = _aantal * _eenheid;
            result = "De totaalprijs voor " + _aantal + " koekje(s) van het type " + soort + " (eenheidsprijs: €" + _eenheid + ") + 21% BTW";
            if (calcResult > 25.0M)
            {
                calcResult -= calcPerc(calcResult,(Decimal)Reduction.big);
                result += " met 10 % korting";
            }
            if (_special)
            {
                calcResult -= calcPerc(calcResult,(Decimal)Reduction.tenthCustomer);
                result += " en nog een extra 5% korting (elke 10e klant)";
            }
            if (_gamble)
            {
                calcResult -= calcPerc(calcResult,(Decimal)Reduction.goodGamble);
                result += " en nog een extra korting van 15% (goed gegokt!!)";
            }
            calcResult += calcPerc(calcResult,_btw);

            result += " bedraagt €" + calcResult + ".";

            return result;
        }

        private Decimal calcPerc(Decimal subResult, Decimal reduction)
        {
            return (subResult * reduction) / 100.0M;
        }

    }
}
