using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Koekenwinkeltje
{
    class UserInputValidation
    {
       public bool ValidateDouble(string invoer)
        {
            try
            {
                double getal = double.Parse(invoer, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
                if (getal < 0)
                {
                    MessageBox.Show("Geef een getal in dat groter is dan 0", "NegativeNumber", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;

            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException error, het getal is te groot.","OverflowException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(FormatException)
            {
                MessageBox.Show("Je moet een getal invoeren!", "FormatException error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
