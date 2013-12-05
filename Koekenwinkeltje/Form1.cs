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
            }
            

        }
    }
}
