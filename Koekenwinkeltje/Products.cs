using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Koekenwinkeltje
{
    class Products
    {
        public static Dictionary<string, double> producten = new Dictionary<string, double>();
        /// <summary>
        /// Reads txt file with special format -> [key]||[pair] newline
        /// </summary>
        /// <param name="filename">string path to the .txt file</param>
        public static void GetProducts(string filename)
        {            
            string products;
            StreamReader readFile = new StreamReader(filename);

            products = readFile.ReadToEnd();
            readFile.Close();

            //MatchCollection mc = Regex.Matches(products, "(?<product>[a-zA-Z ]+).*(?<prijs>\\d+(\\.\\d{1,2}))");
            foreach (Match m in Regex.Matches(products, "(?<product>[a-zA-Z ]+).*(?<prijs>\\d+(\\.\\d{1,2}))"))
            {
                producten.Add(m.Groups["product"].Value, Double.Parse(m.Groups["prijs"].Value,NumberStyles.AllowDecimalPoint,NumberFormatInfo.InvariantInfo));
            }
        }
    }
}
