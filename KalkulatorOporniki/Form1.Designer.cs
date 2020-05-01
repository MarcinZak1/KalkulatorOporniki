namespace KalkulatorOporniki
{
    partial class Form1
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
            this.cbPasek1 = new System.Windows.Forms.ComboBox();
            this.cbPasek5 = new System.Windows.Forms.ComboBox();
            this.cbPasek4 = new System.Windows.Forms.ComboBox();
            this.cbPasek3 = new System.Windows.Forms.ComboBox();
            this.cbPasek2 = new System.Windows.Forms.ComboBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rb5paskow = new System.Windows.Forms.RadioButton();
            this.rb4paski = new System.Windows.Forms.RadioButton();
            this.opornik = new System.Windows.Forms.Panel();
            this.pasek5 = new System.Windows.Forms.Panel();
            this.pasek4 = new System.Windows.Forms.Panel();
            this.pasek3 = new System.Windows.Forms.Panel();
            this.pasek2 = new System.Windows.Forms.Panel();
            this.pasek1 = new System.Windows.Forms.Panel();
            this.lblWynik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbJednostki = new System.Windows.Forms.GroupBox();
            this.rbMohm = new System.Windows.Forms.RadioButton();
            this.rbKohm = new System.Windows.Forms.RadioButton();
            this.rbOhm = new System.Windows.Forms.RadioButton();
            this.gb.SuspendLayout();
            this.opornik.SuspendLayout();
            this.gbJednostki.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPasek1
            // 
            this.cbPasek1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasek1.Enabled = false;
            this.cbPasek1.FormattingEnabled = true;
            this.cbPasek1.Items.AddRange(new object[] {
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fiotelowy",
            "Szary",
            "Biały"});
            this.cbPasek1.Location = new System.Drawing.Point(188, 25);
            this.cbPasek1.Name = "cbPasek1";
            this.cbPasek1.Size = new System.Drawing.Size(256, 21);
            this.cbPasek1.TabIndex = 0;
            this.cbPasek1.SelectedIndexChanged += new System.EventHandler(this.cbPaski_SelectedIndexChanged);
            // 
            // cbPasek5
            // 
            this.cbPasek5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasek5.Enabled = false;
            this.cbPasek5.FormattingEnabled = true;
            this.cbPasek5.Items.AddRange(new object[] {
            "Srebrny",
            "Złoty",
            "Brązowy",
            "Czerwony",
            "Zielony",
            "Niebieski",
            "Fiotelowy",
            "Szary"});
            this.cbPasek5.Location = new System.Drawing.Point(188, 207);
            this.cbPasek5.Name = "cbPasek5";
            this.cbPasek5.Size = new System.Drawing.Size(256, 21);
            this.cbPasek5.TabIndex = 1;
            this.cbPasek5.SelectedIndexChanged += new System.EventHandler(this.cbPaski_SelectedIndexChanged);
            // 
            // cbPasek4
            // 
            this.cbPasek4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasek4.Enabled = false;
            this.cbPasek4.FormattingEnabled = true;
            this.cbPasek4.Items.AddRange(new object[] {
            "Srebrny",
            "Złoty",
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fiotelowy"});
            this.cbPasek4.Location = new System.Drawing.Point(188, 164);
            this.cbPasek4.Name = "cbPasek4";
            this.cbPasek4.Size = new System.Drawing.Size(256, 21);
            this.cbPasek4.TabIndex = 2;
            this.cbPasek4.SelectedIndexChanged += new System.EventHandler(this.cbPaski_SelectedIndexChanged);
            // 
            // cbPasek3
            // 
            this.cbPasek3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasek3.Enabled = false;
            this.cbPasek3.FormattingEnabled = true;
            this.cbPasek3.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fiotelowy",
            "Szary",
            "Biały"});
            this.cbPasek3.Location = new System.Drawing.Point(188, 119);
            this.cbPasek3.Name = "cbPasek3";
            this.cbPasek3.Size = new System.Drawing.Size(256, 21);
            this.cbPasek3.TabIndex = 3;
            this.cbPasek3.SelectedIndexChanged += new System.EventHandler(this.cbPaski_SelectedIndexChanged);
            // 
            // cbPasek2
            // 
            this.cbPasek2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPasek2.Enabled = false;
            this.cbPasek2.FormattingEnabled = true;
            this.cbPasek2.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fiotelowy",
            "Szary",
            "Biały"});
            this.cbPasek2.Location = new System.Drawing.Point(188, 74);
            this.cbPasek2.Name = "cbPasek2";
            this.cbPasek2.Size = new System.Drawing.Size(256, 21);
            this.cbPasek2.TabIndex = 4;
            this.cbPasek2.SelectedIndexChanged += new System.EventHandler(this.cbPaski_SelectedIndexChanged);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rb5paskow);
            this.gb.Controls.Add(this.rb4paski);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gb.Location = new System.Drawing.Point(12, 59);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(122, 94);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            this.gb.Text = "Wybierz opornik";
            // 
            // rb5paskow
            // 
            this.rb5paskow.AutoSize = true;
            this.rb5paskow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb5paskow.Location = new System.Drawing.Point(6, 55);
            this.rb5paskow.Name = "rb5paskow";
            this.rb5paskow.Size = new System.Drawing.Size(78, 19);
            this.rb5paskow.TabIndex = 1;
            this.rb5paskow.Text = "5 Pasków";
            this.rb5paskow.UseVisualStyleBackColor = true;
            this.rb5paskow.CheckedChanged += new System.EventHandler(this.rb5paskow_CheckedChanged);
            // 
            // rb4paski
            // 
            this.rb4paski.AutoSize = true;
            this.rb4paski.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rb4paski.Location = new System.Drawing.Point(7, 20);
            this.rb4paski.Name = "rb4paski";
            this.rb4paski.Size = new System.Drawing.Size(65, 19);
            this.rb4paski.TabIndex = 0;
            this.rb4paski.Text = "4 Paski";
            this.rb4paski.UseVisualStyleBackColor = true;
            this.rb4paski.CheckedChanged += new System.EventHandler(this.rb4paski_CheckedChanged);
            // 
            // opornik
            // 
            this.opornik.BackColor = System.Drawing.Color.Aqua;
            this.opornik.Controls.Add(this.pasek5);
            this.opornik.Controls.Add(this.pasek4);
            this.opornik.Controls.Add(this.pasek3);
            this.opornik.Controls.Add(this.pasek2);
            this.opornik.Controls.Add(this.pasek1);
            this.opornik.Location = new System.Drawing.Point(42, 308);
            this.opornik.Name = "opornik";
            this.opornik.Size = new System.Drawing.Size(460, 111);
            this.opornik.TabIndex = 6;
            // 
            // pasek5
            // 
            this.pasek5.Location = new System.Drawing.Point(387, 0);
            this.pasek5.Name = "pasek5";
            this.pasek5.Size = new System.Drawing.Size(49, 111);
            this.pasek5.TabIndex = 1;
            // 
            // pasek4
            // 
            this.pasek4.Location = new System.Drawing.Point(302, 0);
            this.pasek4.Name = "pasek4";
            this.pasek4.Size = new System.Drawing.Size(49, 111);
            this.pasek4.TabIndex = 1;
            // 
            // pasek3
            // 
            this.pasek3.Location = new System.Drawing.Point(213, 0);
            this.pasek3.Name = "pasek3";
            this.pasek3.Size = new System.Drawing.Size(49, 111);
            this.pasek3.TabIndex = 1;
            // 
            // pasek2
            // 
            this.pasek2.Location = new System.Drawing.Point(124, 0);
            this.pasek2.Name = "pasek2";
            this.pasek2.Size = new System.Drawing.Size(49, 111);
            this.pasek2.TabIndex = 1;
            // 
            // pasek1
            // 
            this.pasek1.BackColor = System.Drawing.Color.Aqua;
            this.pasek1.Location = new System.Drawing.Point(39, 0);
            this.pasek1.Name = "pasek1";
            this.pasek1.Size = new System.Drawing.Size(49, 111);
            this.pasek1.TabIndex = 0;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynik.Location = new System.Drawing.Point(460, 251);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(0, 29);
            this.lblWynik.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(170, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Twój opornik";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(625, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 47);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbJednostki
            // 
            this.gbJednostki.Controls.Add(this.rbMohm);
            this.gbJednostki.Controls.Add(this.rbKohm);
            this.gbJednostki.Controls.Add(this.rbOhm);
            this.gbJednostki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbJednostki.Location = new System.Drawing.Point(606, 303);
            this.gbJednostki.Name = "gbJednostki";
            this.gbJednostki.Size = new System.Drawing.Size(134, 115);
            this.gbJednostki.TabIndex = 10;
            this.gbJednostki.TabStop = false;
            this.gbJednostki.Text = "Wybierz jednostkę";
            // 
            // rbMohm
            // 
            this.rbMohm.AutoSize = true;
            this.rbMohm.Location = new System.Drawing.Point(6, 92);
            this.rbMohm.Name = "rbMohm";
            this.rbMohm.Size = new System.Drawing.Size(63, 19);
            this.rbMohm.TabIndex = 2;
            this.rbMohm.Text = "MOhm";
            this.rbMohm.UseVisualStyleBackColor = true;
            this.rbMohm.CheckedChanged += new System.EventHandler(this.rbMohm_CheckedChanged);
            // 
            // rbKohm
            // 
            this.rbKohm.AutoSize = true;
            this.rbKohm.Location = new System.Drawing.Point(6, 53);
            this.rbKohm.Name = "rbKohm";
            this.rbKohm.Size = new System.Drawing.Size(58, 19);
            this.rbKohm.TabIndex = 1;
            this.rbKohm.Text = "kOhm";
            this.rbKohm.UseVisualStyleBackColor = true;
            this.rbKohm.CheckedChanged += new System.EventHandler(this.rbKohm_CheckedChanged);
            // 
            // rbOhm
            // 
            this.rbOhm.AutoSize = true;
            this.rbOhm.Location = new System.Drawing.Point(6, 19);
            this.rbOhm.Name = "rbOhm";
            this.rbOhm.Size = new System.Drawing.Size(52, 19);
            this.rbOhm.TabIndex = 0;
            this.rbOhm.Text = "Ohm";
            this.rbOhm.UseVisualStyleBackColor = true;
            this.rbOhm.CheckedChanged += new System.EventHandler(this.rbOhm_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbJednostki);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.opornik);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.cbPasek2);
            this.Controls.Add(this.cbPasek3);
            this.Controls.Add(this.cbPasek4);
            this.Controls.Add(this.cbPasek5);
            this.Controls.Add(this.cbPasek1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator do oporników";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.opornik.ResumeLayout(false);
            this.gbJednostki.ResumeLayout(false);
            this.gbJednostki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPasek1;
        private System.Windows.Forms.ComboBox cbPasek5;
        private System.Windows.Forms.ComboBox cbPasek4;
        private System.Windows.Forms.ComboBox cbPasek3;
        private System.Windows.Forms.ComboBox cbPasek2;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rb5paskow;
        private System.Windows.Forms.RadioButton rb4paski;
        private System.Windows.Forms.Panel opornik;
        private System.Windows.Forms.Panel pasek1;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Panel pasek5;
        private System.Windows.Forms.Panel pasek4;
        private System.Windows.Forms.Panel pasek3;
        private System.Windows.Forms.Panel pasek2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbJednostki;
        private System.Windows.Forms.RadioButton rbMohm;
        private System.Windows.Forms.RadioButton rbKohm;
        private System.Windows.Forms.RadioButton rbOhm;
    }
}

