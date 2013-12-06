namespace Koekenwinkeltje
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.txtBtw = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEenheid = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.gbGamble = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGamble = new System.Windows.Forms.TextBox();
            this.btnGamble = new System.Windows.Forms.Button();
            this.lbKeuze = new System.Windows.Forms.ListBox();
            this.gbGamble.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(384, 47);
            this.txtAantal.MaxLength = 10;
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(115, 20);
            this.txtAantal.TabIndex = 1;
            this.txtAantal.Tag = "";
            // 
            // txtBtw
            // 
            this.txtBtw.Location = new System.Drawing.Point(384, 121);
            this.txtBtw.MaxLength = 2;
            this.txtBtw.Name = "txtBtw";
            this.txtBtw.Size = new System.Drawing.Size(115, 20);
            this.txtBtw.TabIndex = 2;
            this.txtBtw.Tag = "";
            // 
            // btnBereken
            // 
            this.btnBereken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBereken.Location = new System.Drawing.Point(384, 195);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(115, 26);
            this.btnBereken.TabIndex = 3;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(301, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 27);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(399, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 6;
            this.label1.Tag = "d";
            this.label1.Text = "Koekje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Tag = "d";
            this.label2.Text = "Aantal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 8;
            this.label3.Tag = "d";
            this.label3.Text = "Btw";
            // 
            // lblEenheid
            // 
            this.lblEenheid.AutoSize = true;
            this.lblEenheid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEenheid.Location = new System.Drawing.Point(12, 238);
            this.lblEenheid.Name = "lblEenheid";
            this.lblEenheid.Size = new System.Drawing.Size(0, 16);
            this.lblEenheid.TabIndex = 9;
            this.lblEenheid.Tag = "lbl";
            // 
            // lblTotaal
            // 
            this.lblTotaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(9, 271);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(499, 108);
            this.lblTotaal.TabIndex = 10;
            this.lblTotaal.Tag = "lbl";
            // 
            // gbGamble
            // 
            this.gbGamble.Controls.Add(this.label6);
            this.gbGamble.Controls.Add(this.txtGamble);
            this.gbGamble.Controls.Add(this.btnGamble);
            this.gbGamble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGamble.Location = new System.Drawing.Point(12, 382);
            this.gbGamble.Name = "gbGamble";
            this.gbGamble.Size = new System.Drawing.Size(220, 56);
            this.gbGamble.TabIndex = 11;
            this.gbGamble.TabStop = false;
            this.gbGamble.Text = "Geef een getal in tussen 0 en 10";
            this.gbGamble.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 2;
            this.label6.Tag = "d";
            this.label6.Text = "Getal:";
            // 
            // txtGamble
            // 
            this.txtGamble.Location = new System.Drawing.Point(62, 21);
            this.txtGamble.MaxLength = 1;
            this.txtGamble.Name = "txtGamble";
            this.txtGamble.Size = new System.Drawing.Size(100, 22);
            this.txtGamble.TabIndex = 1;
            this.txtGamble.Tag = "lbl";
            this.txtGamble.TextChanged += new System.EventHandler(this.txtGamble_TextChanged);
            this.txtGamble.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGamble_KeyPress);
            // 
            // btnGamble
            // 
            this.btnGamble.Location = new System.Drawing.Point(168, 21);
            this.btnGamble.Name = "btnGamble";
            this.btnGamble.Size = new System.Drawing.Size(39, 23);
            this.btnGamble.TabIndex = 0;
            this.btnGamble.Text = "OK";
            this.btnGamble.UseVisualStyleBackColor = true;
            this.btnGamble.Click += new System.EventHandler(this.btnGamble_Click);
            // 
            // lbKeuze
            // 
            this.lbKeuze.FormattingEnabled = true;
            this.lbKeuze.Location = new System.Drawing.Point(12, 26);
            this.lbKeuze.Name = "lbKeuze";
            this.lbKeuze.Size = new System.Drawing.Size(348, 199);
            this.lbKeuze.TabIndex = 0;
            this.lbKeuze.Tag = "";
            this.lbKeuze.SelectedIndexChanged += new System.EventHandler(this.lbKeuze_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.lbKeuze);
            this.Controls.Add(this.gbGamble);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblEenheid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtBtw);
            this.Controls.Add(this.txtAantal);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmMain";
            this.Text = "Koekewinkeltje";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbGamble.ResumeLayout(false);
            this.gbGamble.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAantal;
        private System.Windows.Forms.TextBox txtBtw;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEenheid;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.GroupBox gbGamble;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGamble;
        private System.Windows.Forms.Button btnGamble;
        private System.Windows.Forms.ListBox lbKeuze;
    }
}

