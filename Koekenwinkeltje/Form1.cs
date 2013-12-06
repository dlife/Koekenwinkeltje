using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koekenwinkeltje
{
    public partial class frmMain : Form
    {
        public int count = 0;
        public int gambleCount = 0;
        bool gamble = false;

        public frmMain()
        {
            InitializeComponent();
            Products.GetProducts("Producten.txt");
            lbKeuze.DataSource = new BindingSource(Products.producten.Keys, null);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbKeuze.SelectedIndex = -1;
            lblEenheid.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbKeuze_SelectedIndexChanged(object sender, EventArgs e)
        {
            string uitvoer = "Eenhiedsprijs voor ";
            if (lbKeuze.SelectedIndex != -1)
            {
                string curentItem = lbKeuze.SelectedItem.ToString();
                lblEenheid.Text = uitvoer + curentItem + " = € " + Products.producten[curentItem].ToString();
                txtAantal.Focus();
            }


        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            count++;
            BtnCalc();
        }

        private void btnGamble_Click(object sender, EventArgs e)
        {
            string message = "";
            int getal = 0;
            int gok = int.Parse(txtGamble.Text);
            Random rndGetal = new Random();

            getal = rndGetal.Next(1, 11);
            message = "Jouw getal: " + gok + " te raden getal: " + getal + ".";
            gambleCount++;

            if (gambleCount !=3)
            {
                if (TestGamble(getal, gok, message))
                {return;}
            }
            else
            {

                if (TestGamble(getal, gok, message))
                { return; }
                Shift();
                gambleCount = 0;
            }
            txtGamble.Text = "";
            MessageBox.Show(message, "Gokje", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            
        }

        public void Shift()
        {
            lbKeuze.Enabled = !lbKeuze.Enabled;
            txtAantal.Enabled = !txtAantal.Enabled;
            txtBtw.Enabled = !txtBtw.Enabled;
            btnBereken.Enabled = !btnBereken.Enabled;
            gbGamble.Visible = !gbGamble.Visible;
        }

        private void BtnCalc()
        {
            bool test = count == 10;
            if (test)
            {
                Shift();
                txtGamble.Focus();
                count = 0;
                return;
            }
            Calculate bereken = new Calculate(test, Double.Parse(txtAantal.Text), Double.Parse(txtBtw.Text), lbKeuze.SelectedItem.ToString(), gamble);
            lblTotaal.Text = bereken.GetResult(lbKeuze.SelectedItem.ToString());
        }

        private bool TestGamble(int getal, int gok, string message)
        {
            bool test = getal == gok;
            if (test)
            {
                message += "\nJe hebt extra korting gewonnen!!";
                gamble = true;
                Shift();
                gambleCount = 0;
                MessageBox.Show(message, "Gewonnen", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                BtnCalc();
            }
            return test;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item == TextBox )
                {
                    
                }
            }
        }
    }
}
