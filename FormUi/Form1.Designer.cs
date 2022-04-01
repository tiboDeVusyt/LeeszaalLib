namespace FormUi
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
            this.lstReaders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbSelectReader = new System.Windows.Forms.GroupBox();
            this.lblMagColor = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.grbCounts = new System.Windows.Forms.GroupBox();
            this.lblBothCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMagazineColorCount = new System.Windows.Forms.Label();
            this.lblHatCount = new System.Windows.Forms.Label();
            this.cmbKleur = new System.Windows.Forms.ComboBox();
            this.cmbHat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.btnAddLezers = new System.Windows.Forms.Button();
            this.grbSelectReader.SuspendLayout();
            this.grbCounts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReaders
            // 
            this.lstReaders.FormattingEnabled = true;
            this.lstReaders.ItemHeight = 16;
            this.lstReaders.Location = new System.Drawing.Point(19, 21);
            this.lstReaders.Name = "lstReaders";
            this.lstReaders.Size = new System.Drawing.Size(178, 212);
            this.lstReaders.TabIndex = 0;
            this.lstReaders.SelectedIndexChanged += new System.EventHandler(this.lstReaders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Persoon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leeftijd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hoofd deksel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tijdschrift:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "kleur:";
            // 
            // grbSelectReader
            // 
            this.grbSelectReader.Controls.Add(this.lblMagColor);
            this.grbSelectReader.Controls.Add(this.lblHat);
            this.grbSelectReader.Controls.Add(this.lblAge);
            this.grbSelectReader.Controls.Add(this.lstReaders);
            this.grbSelectReader.Controls.Add(this.label3);
            this.grbSelectReader.Controls.Add(this.label1);
            this.grbSelectReader.Controls.Add(this.label2);
            this.grbSelectReader.Controls.Add(this.label4);
            this.grbSelectReader.Controls.Add(this.label5);
            this.grbSelectReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSelectReader.Location = new System.Drawing.Point(13, 12);
            this.grbSelectReader.Name = "grbSelectReader";
            this.grbSelectReader.Size = new System.Drawing.Size(479, 242);
            this.grbSelectReader.TabIndex = 11;
            this.grbSelectReader.TabStop = false;
            this.grbSelectReader.Text = "Select Reader";
            // 
            // lblMagColor
            // 
            this.lblMagColor.AutoSize = true;
            this.lblMagColor.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMagColor.Location = new System.Drawing.Point(361, 191);
            this.lblMagColor.Name = "lblMagColor";
            this.lblMagColor.Size = new System.Drawing.Size(39, 16);
            this.lblMagColor.TabIndex = 8;
            this.lblMagColor.Text = "Color";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHat.Location = new System.Drawing.Point(361, 130);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(28, 16);
            this.lblHat.TabIndex = 7;
            this.lblHat.Text = "Hat";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAge.Location = new System.Drawing.Point(361, 95);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age";
            // 
            // grbCounts
            // 
            this.grbCounts.Controls.Add(this.lblBothCount);
            this.grbCounts.Controls.Add(this.label8);
            this.grbCounts.Controls.Add(this.lblMagazineColorCount);
            this.grbCounts.Controls.Add(this.lblHatCount);
            this.grbCounts.Controls.Add(this.cmbKleur);
            this.grbCounts.Controls.Add(this.cmbHat);
            this.grbCounts.Controls.Add(this.label7);
            this.grbCounts.Controls.Add(this.label6);
            this.grbCounts.Location = new System.Drawing.Point(13, 261);
            this.grbCounts.Name = "grbCounts";
            this.grbCounts.Size = new System.Drawing.Size(479, 154);
            this.grbCounts.TabIndex = 12;
            this.grbCounts.TabStop = false;
            this.grbCounts.Text = "Counts";
            // 
            // lblBothCount
            // 
            this.lblBothCount.AutoSize = true;
            this.lblBothCount.Location = new System.Drawing.Point(342, 107);
            this.lblBothCount.Name = "lblBothCount";
            this.lblBothCount.Size = new System.Drawing.Size(34, 16);
            this.lblBothCount.TabIndex = 15;
            this.lblBothCount.Text = "Both";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Beide:";
            // 
            // lblMagazineColorCount
            // 
            this.lblMagazineColorCount.AutoSize = true;
            this.lblMagazineColorCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMagazineColorCount.Location = new System.Drawing.Point(345, 68);
            this.lblMagazineColorCount.Name = "lblMagazineColorCount";
            this.lblMagazineColorCount.Size = new System.Drawing.Size(34, 16);
            this.lblMagazineColorCount.TabIndex = 13;
            this.lblMagazineColorCount.Text = "Mag";
            // 
            // lblHatCount
            // 
            this.lblHatCount.AutoSize = true;
            this.lblHatCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHatCount.Location = new System.Drawing.Point(345, 30);
            this.lblHatCount.Name = "lblHatCount";
            this.lblHatCount.Size = new System.Drawing.Size(28, 16);
            this.lblHatCount.TabIndex = 12;
            this.lblHatCount.Text = "Hat";
            // 
            // cmbKleur
            // 
            this.cmbKleur.FormattingEnabled = true;
            this.cmbKleur.Location = new System.Drawing.Point(165, 59);
            this.cmbKleur.Name = "cmbKleur";
            this.cmbKleur.Size = new System.Drawing.Size(121, 24);
            this.cmbKleur.TabIndex = 11;
            this.cmbKleur.SelectedIndexChanged += new System.EventHandler(this.cmbKleur_SelectedIndexChanged);
            // 
            // cmbHat
            // 
            this.cmbHat.FormattingEnabled = true;
            this.cmbHat.Location = new System.Drawing.Point(165, 22);
            this.cmbHat.Name = "cmbHat";
            this.cmbHat.Size = new System.Drawing.Size(121, 24);
            this.cmbHat.TabIndex = 10;
            this.cmbHat.SelectedIndexChanged += new System.EventHandler(this.cmbHat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "kleur:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hoofd deksel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLezers);
            this.groupBox1.Controls.Add(this.txtAddCount);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(13, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lezers toevoegen";
            // 
            // txtAddCount
            // 
            this.txtAddCount.Location = new System.Drawing.Point(186, 40);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(100, 22);
            this.txtAddCount.TabIndex = 1;
            // 
            // btnAddLezers
            // 
            this.btnAddLezers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLezers.Location = new System.Drawing.Point(329, 38);
            this.btnAddLezers.Name = "btnAddLezers";
            this.btnAddLezers.Size = new System.Drawing.Size(75, 23);
            this.btnAddLezers.TabIndex = 2;
            this.btnAddLezers.Text = "Add";
            this.btnAddLezers.UseVisualStyleBackColor = true;
            this.btnAddLezers.Click += new System.EventHandler(this.btnAddLezers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbCounts);
            this.Controls.Add(this.grbSelectReader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbSelectReader.ResumeLayout(false);
            this.grbSelectReader.PerformLayout();
            this.grbCounts.ResumeLayout(false);
            this.grbCounts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbSelectReader;
        private System.Windows.Forms.Label lblMagColor;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox grbCounts;
        private System.Windows.Forms.Label lblHatCount;
        private System.Windows.Forms.ComboBox cmbKleur;
        private System.Windows.Forms.ComboBox cmbHat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBothCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMagazineColorCount;
        private System.Windows.Forms.Button btnAddLezers;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.Label label9;
    }
}

