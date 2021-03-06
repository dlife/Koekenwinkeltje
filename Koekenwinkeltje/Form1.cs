﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Koekenwinkeltje
{
    public partial class frmMain : Form
    {
        UserInputValidation valid = new UserInputValidation();
        Calculate reken = new Calculate();

        public int count = 0;
        public int gambleCount = 0;
        public bool wrongKey = false;

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
            reken.gamble = false;
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
           
            if (!valid.ValidateDouble(txtAantal.Text))
            {
                return;
            }
            if (!valid.ValidateDouble(txtBtw.Text))
            {
                return;
            }
            if (lbKeuze.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer een product uit de lijst", "Geen product geselcteerd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            count++;
            reken.aantal = Decimal.Parse(txtAantal.Text);
            reken.btw = Decimal.Parse(txtBtw.Text);
            reken.eenheid = Decimal.Parse(Products.producten[lbKeuze.SelectedItem.ToString()].ToString());
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
            
            MessageBox.Show(message, "Gokje", MessageBoxButtons.OK, MessageBoxIcon.None);
            txtGamble.Focus();
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
            bool test = count   == 10;
            if (test)
            {
                Shift();
                txtGamble.Focus();
                count = 0;
                return;
            }
            lblTotaal.Text = reken.GetResult(lbKeuze.SelectedItem.ToString());
        }

        private bool TestGamble(int getal, int gok, string message)
        {
            bool test = getal == gok;
            if (test)
            {
                message += "\nJe hebt extra korting gewonnen!!";
                reken.gamble = true;
                Shift();
                gambleCount = 0;
                MessageBox.Show(message, "Gewonnen", MessageBoxButtons.OK, MessageBoxIcon.None);
                BtnCalc();
                reken.gamble = false;
            }
            return test;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = "";
                    (item as TextBox).Enabled = true;
                }
                if (item is Label)
                {
                    if ((item as Label).Tag.ToString() ==  "lbl")
                    {
                        (item as Label).Text = "";
                    }
                }
            }
            btnBereken.Enabled = true;
            lbKeuze.Enabled = true;
            lbKeuze.SelectedIndex = -1;
            gbGamble.Visible = false;
            wrongKey = false;
        }

        private void txtGamble_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = e.KeyChar.ToString();
            if (Regex.IsMatch(s,"[^\\d\\s]"))
            {
                wrongKey = true;
                MessageBox.Show("Vul een getal in van 1 tot 10");
            }
        }

        private void txtGamble_TextChanged(object sender, EventArgs e)
        {
            if (wrongKey == true)
            {
                txtGamble.Text = "";
            }
            else
            {
                btnGamble.Focus();
            }
            wrongKey = false;
        }
    }
}
