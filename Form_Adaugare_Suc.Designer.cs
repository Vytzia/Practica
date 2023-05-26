namespace Fizzler
{
    partial class Form_Adaugare_Suc
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
            this.components = new System.ComponentModel.Container();
            this.button_image = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_pret = new System.Windows.Forms.TextBox();
            this.textBox_volum = new System.Windows.Forms.TextBox();
            this.textBox_proc_zahar = new System.Windows.Forms.TextBox();
            this.checkedListBox_fructe = new System.Windows.Forms.CheckedListBox();
            this.comboBox_categorie = new System.Windows.Forms.ComboBox();
            this.button_adauga = new System.Windows.Forms.Button();
            this.button_anuleaza = new System.Windows.Forms.Button();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_image
            // 
            this.button_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_image.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_image.Location = new System.Drawing.Point(98, 71);
            this.button_image.Name = "button_image";
            this.button_image.Size = new System.Drawing.Size(218, 218);
            this.button_image.TabIndex = 0;
            this.button_image.Text = "apăsați pentru a adăuga imagine";
            this.button_image.UseVisualStyleBackColor = true;
            this.button_image.Click += new System.EventHandler(this.button_image_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(322, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(322, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(128, 29);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Nume băutură:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.Location = new System.Drawing.Point(322, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(128, 29);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Preț(lei):";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox4.Location = new System.Drawing.Point(322, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(128, 29);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Volum(l):";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox5.Location = new System.Drawing.Point(322, 198);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(128, 29);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Zahar(%):";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox6.Location = new System.Drawing.Point(322, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(128, 29);
            this.textBox6.TabIndex = 6;
            this.textBox6.Text = "Fructe:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox7.Location = new System.Drawing.Point(322, 230);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(128, 29);
            this.textBox7.TabIndex = 7;
            this.textBox7.Text = "Categorie:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(511, 70);
            this.textBox_ID.MaxLength = 5;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(199, 29);
            this.textBox_ID.TabIndex = 8;
            this.textBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_ID.Enter += new System.EventHandler(this.textBox_ID_Enter);
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            this.textBox_ID.Leave += new System.EventHandler(this.textBox_ID_Leave);
            // 
            // textBox_nume
            // 
            this.textBox_nume.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_nume.Location = new System.Drawing.Point(456, 102);
            this.textBox_nume.MaxLength = 30;
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(254, 29);
            this.textBox_nume.TabIndex = 9;
            this.textBox_nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_pret
            // 
            this.textBox_pret.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_pret.Location = new System.Drawing.Point(555, 134);
            this.textBox_pret.MaxLength = 7;
            this.textBox_pret.Name = "textBox_pret";
            this.textBox_pret.Size = new System.Drawing.Size(155, 29);
            this.textBox_pret.TabIndex = 10;
            this.textBox_pret.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_pret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pret_KeyPress);
            // 
            // textBox_volum
            // 
            this.textBox_volum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_volum.Location = new System.Drawing.Point(555, 166);
            this.textBox_volum.MaxLength = 5;
            this.textBox_volum.Name = "textBox_volum";
            this.textBox_volum.Size = new System.Drawing.Size(155, 29);
            this.textBox_volum.TabIndex = 11;
            this.textBox_volum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_volum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_volum_KeyPress);
            // 
            // textBox_proc_zahar
            // 
            this.textBox_proc_zahar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_proc_zahar.Location = new System.Drawing.Point(555, 198);
            this.textBox_proc_zahar.MaxLength = 5;
            this.textBox_proc_zahar.Name = "textBox_proc_zahar";
            this.textBox_proc_zahar.Size = new System.Drawing.Size(155, 29);
            this.textBox_proc_zahar.TabIndex = 12;
            this.textBox_proc_zahar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_proc_zahar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_proc_zahar_KeyPress);
            // 
            // checkedListBox_fructe
            // 
            this.checkedListBox_fructe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.checkedListBox_fructe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_fructe.CheckOnClick = true;
            this.checkedListBox_fructe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkedListBox_fructe.FormattingEnabled = true;
            this.checkedListBox_fructe.Items.AddRange(new object[] {
            "Struguri",
            "Kiwi",
            "Căpșune",
            "Afine",
            "Măr",
            "Banane",
            "Portocale",
            "Ananas",
            "Multifruct"});
            this.checkedListBox_fructe.Location = new System.Drawing.Point(456, 262);
            this.checkedListBox_fructe.MultiColumn = true;
            this.checkedListBox_fructe.Name = "checkedListBox_fructe";
            this.checkedListBox_fructe.Size = new System.Drawing.Size(254, 122);
            this.checkedListBox_fructe.TabIndex = 14;
            // 
            // comboBox_categorie
            // 
            this.comboBox_categorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_categorie.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_categorie.FormattingEnabled = true;
            this.comboBox_categorie.Items.AddRange(new object[] {
            "Standart",
            "Premium",
            "Kids",
            "Extra"});
            this.comboBox_categorie.Location = new System.Drawing.Point(456, 230);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(254, 29);
            this.comboBox_categorie.TabIndex = 15;
            // 
            // button_adauga
            // 
            this.button_adauga.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_adauga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_adauga.Location = new System.Drawing.Point(456, 396);
            this.button_adauga.Name = "button_adauga";
            this.button_adauga.Size = new System.Drawing.Size(79, 43);
            this.button_adauga.TabIndex = 16;
            this.button_adauga.Text = "adaugă";
            this.button_adauga.UseVisualStyleBackColor = true;
            this.button_adauga.Click += new System.EventHandler(this.button_adauga_Click);
            // 
            // button_anuleaza
            // 
            this.button_anuleaza.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_anuleaza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_anuleaza.Location = new System.Drawing.Point(631, 396);
            this.button_anuleaza.Name = "button_anuleaza";
            this.button_anuleaza.Size = new System.Drawing.Size(79, 43);
            this.button_anuleaza.TabIndex = 17;
            this.button_anuleaza.Text = "anulează";
            this.button_anuleaza.UseVisualStyleBackColor = true;
            this.button_anuleaza.Click += new System.EventHandler(this.button_anuleaza_Click);
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox_ID.Location = new System.Drawing.Point(456, 68);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(49, 29);
            this.comboBox_ID.TabIndex = 18;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_ID.Location = new System.Drawing.Point(577, 47);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(131, 20);
            this.label_ID.TabIndex = 19;
            this.label_ID.Text = "ex. 00001, 39412";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fizzler.Properties.Resources.add_ye;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(135, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Adaugare_Suc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(826, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.button_anuleaza);
            this.Controls.Add(this.button_adauga);
            this.Controls.Add(this.comboBox_categorie);
            this.Controls.Add(this.checkedListBox_fructe);
            this.Controls.Add(this.textBox_proc_zahar);
            this.Controls.Add(this.textBox_volum);
            this.Controls.Add(this.textBox_pret);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_image);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximumSize = new System.Drawing.Size(842, 538);
            this.MinimumSize = new System.Drawing.Size(842, 538);
            this.Name = "Form_Adaugare_Suc";
            this.Text = "Adăugați suc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Adaugare_Suc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_image;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_pret;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox_volum;
        private System.Windows.Forms.TextBox textBox_proc_zahar;
        private System.Windows.Forms.CheckedListBox checkedListBox_fructe;
        private System.Windows.Forms.ComboBox comboBox_categorie;
        private System.Windows.Forms.Button button_adauga;
        private System.Windows.Forms.Button button_anuleaza;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}