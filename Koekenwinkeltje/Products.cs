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
        public static Dictionary<string, Decimal> producten = new Dictionary<string, Decimal>();
        /// <summary>
        /// Reads txt file with special format -> '[key] || [pair] newline'
        /// </summary>
        /// <param name="filename">string path to the .txt file</param>
        public static void GetProducts(string filename)
        {
            
            try
            {
                string products;
                StreamReader readFile = new StreamReader(filename);
                products = readFile.ReadToEnd();
                readFile.Close();

                //MatchCollection mc = Regex.Matches(products, "(?<product>[a-zA-Z ]+).*(?<prijs>\\d+(\\.\\d{1,2}))");
                foreach (Match m in Regex.Matches(products, "(?<product>[a-zA-Z ]+).*(?<prijs>\\d+(\\.\\d{1,2}))"))
                {
                    producten.Add(m.Groups["product"].Value, Decimal.Parse(m.Groups["prijs"].Value, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo));
                }
            }
            catch (FileNotFoundException)
            {
                
                System.Windows.Forms.MessageBox.Show("The " + filename + "is not Found!"
                    + Environment.NewLine + "Please make sure the path is correct","File not found",
                    System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
            catch   (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Couldn't parse the value of the file " + filename + ". "
                    + Environment.NewLine + "Please make sure it is in the write format!", "Wrong format", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }

        }
    }
}
