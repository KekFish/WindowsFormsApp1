
namespace aplikacja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.settings1 = new aplikacja.settings();
            this.stats1 = new aplikacja.stats();
            this.zamowienia1 = new aplikacja.zamowienia();
            this.strona_główna1 = new aplikacja.main();
            this.kasa1 = new aplikacja.Kasa();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 675);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SidePanel.Location = new System.Drawing.Point(0, 41);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(16, 91);
            this.SidePanel.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::aplikacja.Properties.Resources.step_out_64px;
            this.button5.Location = new System.Drawing.Point(12, 512);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 88);
            this.button5.TabIndex = 4;
            this.button5.Text = "Ustawienia";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::aplikacja.Properties.Resources.calculator_64px;
            this.button4.Location = new System.Drawing.Point(12, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 88);
            this.button4.TabIndex = 4;
            this.button4.Text = "Statystyki";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::aplikacja.Properties.Resources.hamburger_64px;
            this.button3.Location = new System.Drawing.Point(12, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 88);
            this.button3.TabIndex = 4;
            this.button3.Text = "Aktualne zamówienia";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::aplikacja.Properties.Resources.cash_register_euro_64px;
            this.button2.Location = new System.Drawing.Point(12, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 88);
            this.button2.TabIndex = 4;
            this.button2.Text = "    Kasa";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::aplikacja.Properties.Resources.monitor_96px;
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Strona główna";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 35);
            this.panel2.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::aplikacja.Properties.Resources.minimize_window_32px;
            this.button7.Location = new System.Drawing.Point(782, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 35);
            this.button7.TabIndex = 1;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseMnemonic = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::aplikacja.Properties.Resources.power_off_button_32px;
            this.button6.Location = new System.Drawing.Point(821, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 35);
            this.button6.TabIndex = 0;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseMnemonic = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(323, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 129);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aplikacja.Properties.Resources.PL_logo_BurgerKing;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(440, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(785, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(278, 36);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Strona internetowa";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // settings1
            // 
            this.settings1.Location = new System.Drawing.Point(215, 166);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(860, 509);
            this.settings1.TabIndex = 10;
            // 
            // stats1
            // 
            this.stats1.Location = new System.Drawing.Point(215, 166);
            this.stats1.Name = "stats1";
            this.stats1.Size = new System.Drawing.Size(860, 509);
            this.stats1.TabIndex = 9;
            // 
            // zamowienia1
            // 
            this.zamowienia1.Location = new System.Drawing.Point(215, 166);
            this.zamowienia1.Name = "zamowienia1";
            this.zamowienia1.Size = new System.Drawing.Size(860, 509);
            this.zamowienia1.TabIndex = 7;
            // 
            // strona_główna1
            // 
            this.strona_główna1.Location = new System.Drawing.Point(215, 161);
            this.strona_główna1.Name = "strona_główna1";
            this.strona_główna1.Size = new System.Drawing.Size(860, 511);
            this.strona_główna1.TabIndex = 5;
            // 
            // kasa1
            // 
            this.kasa1.BackColor = System.Drawing.Color.White;
            this.kasa1.Location = new System.Drawing.Point(215, 160);
            this.kasa1.Name = "kasa1";
            this.kasa1.Size = new System.Drawing.Size(860, 515);
            this.kasa1.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(148)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.Dock = System.Windows.Forms.DockStyle.Right;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::aplikacja.Properties.Resources.info_32px;
            this.button8.Location = new System.Drawing.Point(742, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 35);
            this.button8.TabIndex = 2;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseMnemonic = false;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 675);
            this.Controls.Add(this.settings1);
            this.Controls.Add(this.stats1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.zamowienia1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.strona_główna1);
            this.Controls.Add(this.kasa1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SidePanel;
        private Kasa kasa1;
        private main strona_główna1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private zamowienia zamowienia1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private stats stats1;
        private settings settings1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

