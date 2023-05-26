namespace Fizzler
{
    partial class Fizzler
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.button_rapoarte = new System.Windows.Forms.Button();
            this.button_sucuri = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.groupBox_fructe = new System.Windows.Forms.GroupBox();
            this.clear_button2 = new System.Windows.Forms.Button();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox_categorii = new System.Windows.Forms.GroupBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label_zahar = new System.Windows.Forms.Label();
            this.comboBox_zahar = new System.Windows.Forms.ComboBox();
            this.label_filtrare = new System.Windows.Forms.Label();
            this.comboBox_sortare = new System.Windows.Forms.ComboBox();
            this.label_sortare = new System.Windows.Forms.Label();
            this.button_sterge_suc = new System.Windows.Forms.Button();
            this.button_adauga_suc = new System.Windows.Forms.Button();
            this.butt_go = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.side_panel.SuspendLayout();
            this.groupBox_fructe.SuspendLayout();
            this.groupBox_categorii.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.top_panel.Controls.Add(this.button_cos);
            this.top_panel.Controls.Add(this.button_login);
            this.top_panel.Controls.Add(this.button_rapoarte);
            this.top_panel.Controls.Add(this.button_sucuri);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1184, 40);
            this.top_panel.TabIndex = 0;
            // 
            // button_rapoarte
            // 
            this.button_rapoarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_rapoarte.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_rapoarte.FlatAppearance.BorderSize = 0;
            this.button_rapoarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rapoarte.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rapoarte.ForeColor = System.Drawing.Color.White;
            this.button_rapoarte.Location = new System.Drawing.Point(134, 0);
            this.button_rapoarte.Margin = new System.Windows.Forms.Padding(0);
            this.button_rapoarte.Name = "button_rapoarte";
            this.button_rapoarte.Size = new System.Drawing.Size(136, 40);
            this.button_rapoarte.TabIndex = 1;
            this.button_rapoarte.Text = "Rapoarte";
            this.button_rapoarte.UseVisualStyleBackColor = true;
            this.button_rapoarte.Click += new System.EventHandler(this.button_rapoarte_Click);
            // 
            // button_sucuri
            // 
            this.button_sucuri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_sucuri.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_sucuri.FlatAppearance.BorderSize = 0;
            this.button_sucuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sucuri.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sucuri.ForeColor = System.Drawing.Color.White;
            this.button_sucuri.Location = new System.Drawing.Point(0, 0);
            this.button_sucuri.Margin = new System.Windows.Forms.Padding(0);
            this.button_sucuri.Name = "button_sucuri";
            this.button_sucuri.Size = new System.Drawing.Size(134, 40);
            this.button_sucuri.TabIndex = 0;
            this.button_sucuri.Text = "Sucuri";
            this.button_sucuri.UseVisualStyleBackColor = true;
            this.button_sucuri.Click += new System.EventHandler(this.button_sucuri_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.content_panel);
            this.main_panel.Controls.Add(this.side_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 40);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1184, 683);
            this.main_panel.TabIndex = 1;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content_panel.Location = new System.Drawing.Point(270, 0);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(914, 683);
            this.content_panel.TabIndex = 1;
            // 
            // side_panel
            // 
            this.side_panel.AutoScroll = true;
            this.side_panel.BackColor = System.Drawing.Color.White;
            this.side_panel.Controls.Add(this.button_sterge_suc);
            this.side_panel.Controls.Add(this.button_adauga_suc);
            this.side_panel.Controls.Add(this.butt_go);
            this.side_panel.Controls.Add(this.groupBox_fructe);
            this.side_panel.Controls.Add(this.groupBox_categorii);
            this.side_panel.Controls.Add(this.label_zahar);
            this.side_panel.Controls.Add(this.comboBox_zahar);
            this.side_panel.Controls.Add(this.label_filtrare);
            this.side_panel.Controls.Add(this.comboBox_sortare);
            this.side_panel.Controls.Add(this.label_sortare);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(270, 683);
            this.side_panel.TabIndex = 0;
            // 
            // groupBox_fructe
            // 
            this.groupBox_fructe.Controls.Add(this.clear_button2);
            this.groupBox_fructe.Controls.Add(this.radioButton10);
            this.groupBox_fructe.Controls.Add(this.radioButton11);
            this.groupBox_fructe.Controls.Add(this.radioButton12);
            this.groupBox_fructe.Controls.Add(this.radioButton5);
            this.groupBox_fructe.Controls.Add(this.radioButton6);
            this.groupBox_fructe.Controls.Add(this.radioButton7);
            this.groupBox_fructe.Controls.Add(this.radioButton8);
            this.groupBox_fructe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_fructe.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox_fructe.Location = new System.Drawing.Point(12, 353);
            this.groupBox_fructe.Name = "groupBox_fructe";
            this.groupBox_fructe.Size = new System.Drawing.Size(252, 221);
            this.groupBox_fructe.TabIndex = 13;
            this.groupBox_fructe.TabStop = false;
            this.groupBox_fructe.Text = "Fructe";
            // 
            // clear_button2
            // 
            this.clear_button2.FlatAppearance.BorderSize = 0;
            this.clear_button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.clear_button2.Location = new System.Drawing.Point(223, 192);
            this.clear_button2.Name = "clear_button2";
            this.clear_button2.Size = new System.Drawing.Size(23, 23);
            this.clear_button2.TabIndex = 5;
            this.clear_button2.Text = "x";
            this.clear_button2.UseVisualStyleBackColor = true;
            this.clear_button2.Click += new System.EventHandler(this.clear_button2_Click);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(29, 187);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(78, 20);
            this.radioButton10.TabIndex = 6;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Multifruct";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(29, 161);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(66, 20);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Morcov";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(29, 135);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(48, 20);
            this.radioButton12.TabIndex = 4;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Pere";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(29, 109);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(64, 20);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ananas";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(29, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 20);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Căpșune";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(29, 57);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(67, 20);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Struguri";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(29, 31);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 20);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Măr";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // groupBox_categorii
            // 
            this.groupBox_categorii.Controls.Add(this.clear_button);
            this.groupBox_categorii.Controls.Add(this.radioButton4);
            this.groupBox_categorii.Controls.Add(this.radioButton3);
            this.groupBox_categorii.Controls.Add(this.radioButton2);
            this.groupBox_categorii.Controls.Add(this.radioButton1);
            this.groupBox_categorii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_categorii.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox_categorii.Location = new System.Drawing.Point(12, 203);
            this.groupBox_categorii.Name = "groupBox_categorii";
            this.groupBox_categorii.Size = new System.Drawing.Size(252, 144);
            this.groupBox_categorii.TabIndex = 12;
            this.groupBox_categorii.TabStop = false;
            this.groupBox_categorii.Text = "Categorii";
            // 
            // clear_button
            // 
            this.clear_button.FlatAppearance.BorderSize = 0;
            this.clear_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.clear_button.Location = new System.Drawing.Point(223, 115);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(23, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "x";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(29, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Extra";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(29, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Kids";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(29, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Premium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(29, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standart";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label_zahar
            // 
            this.label_zahar.AutoSize = true;
            this.label_zahar.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zahar.Location = new System.Drawing.Point(15, 144);
            this.label_zahar.Name = "label_zahar";
            this.label_zahar.Size = new System.Drawing.Size(132, 16);
            this.label_zahar.TabIndex = 6;
            this.label_zahar.Text = "Cantitatea de zahăr:";
            // 
            // comboBox_zahar
            // 
            this.comboBox_zahar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_zahar.DisplayMember = "0";
            this.comboBox_zahar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_zahar.FormattingEnabled = true;
            this.comboBox_zahar.Items.AddRange(new object[] {
            "Toate",
            "<=10%",
            "<=15%",
            ">15%"});
            this.comboBox_zahar.Location = new System.Drawing.Point(12, 165);
            this.comboBox_zahar.Name = "comboBox_zahar";
            this.comboBox_zahar.Size = new System.Drawing.Size(252, 23);
            this.comboBox_zahar.TabIndex = 5;
            this.comboBox_zahar.ValueMember = "0";
            // 
            // label_filtrare
            // 
            this.label_filtrare.AutoSize = true;
            this.label_filtrare.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filtrare.Location = new System.Drawing.Point(12, 100);
            this.label_filtrare.Name = "label_filtrare";
            this.label_filtrare.Size = new System.Drawing.Size(89, 28);
            this.label_filtrare.TabIndex = 4;
            this.label_filtrare.Text = "Filtrare:";
            // 
            // comboBox_sortare
            // 
            this.comboBox_sortare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox_sortare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_sortare.FormattingEnabled = true;
            this.comboBox_sortare.Items.AddRange(new object[] {
            "Implicit",
            "Preț crescător",
            "Preț descrescător",
            "Popularitate"});
            this.comboBox_sortare.Location = new System.Drawing.Point(12, 51);
            this.comboBox_sortare.Name = "comboBox_sortare";
            this.comboBox_sortare.Size = new System.Drawing.Size(252, 23);
            this.comboBox_sortare.TabIndex = 3;
            // 
            // label_sortare
            // 
            this.label_sortare.AutoSize = true;
            this.label_sortare.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sortare.Location = new System.Drawing.Point(12, 14);
            this.label_sortare.Name = "label_sortare";
            this.label_sortare.Size = new System.Drawing.Size(91, 28);
            this.label_sortare.TabIndex = 1;
            this.label_sortare.Text = "Sortare:";
            // 
            // button_sterge_suc
            // 
            this.button_sterge_suc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_sterge_suc.BackColor = System.Drawing.Color.Transparent;
            this.button_sterge_suc.BackgroundImage = global::Fizzler.Properties.Resources.remove;
            this.button_sterge_suc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_sterge_suc.FlatAppearance.BorderSize = 0;
            this.button_sterge_suc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sterge_suc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sterge_suc.ForeColor = System.Drawing.Color.White;
            this.button_sterge_suc.Location = new System.Drawing.Point(231, 638);
            this.button_sterge_suc.Name = "button_sterge_suc";
            this.button_sterge_suc.Size = new System.Drawing.Size(33, 33);
            this.button_sterge_suc.TabIndex = 16;
            this.button_sterge_suc.UseVisualStyleBackColor = false;
            this.button_sterge_suc.Click += new System.EventHandler(this.button_sterge_suc_Click);
            // 
            // button_adauga_suc
            // 
            this.button_adauga_suc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_adauga_suc.BackColor = System.Drawing.Color.Transparent;
            this.button_adauga_suc.BackgroundImage = global::Fizzler.Properties.Resources.add;
            this.button_adauga_suc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_adauga_suc.FlatAppearance.BorderSize = 0;
            this.button_adauga_suc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adauga_suc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adauga_suc.ForeColor = System.Drawing.Color.White;
            this.button_adauga_suc.Image = global::Fizzler.Properties.Resources.add;
            this.button_adauga_suc.Location = new System.Drawing.Point(192, 638);
            this.button_adauga_suc.Name = "button_adauga_suc";
            this.button_adauga_suc.Size = new System.Drawing.Size(33, 33);
            this.button_adauga_suc.TabIndex = 15;
            this.button_adauga_suc.UseVisualStyleBackColor = false;
            this.button_adauga_suc.Click += new System.EventHandler(this.button_adauga_suc_Click);
            // 
            // butt_go
            // 
            this.butt_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butt_go.BackgroundImage = global::Fizzler.Properties.Resources.filter;
            this.butt_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butt_go.FlatAppearance.BorderSize = 0;
            this.butt_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_go.ForeColor = System.Drawing.Color.Transparent;
            this.butt_go.Location = new System.Drawing.Point(12, 611);
            this.butt_go.Name = "butt_go";
            this.butt_go.Size = new System.Drawing.Size(60, 60);
            this.butt_go.TabIndex = 14;
            this.butt_go.UseVisualStyleBackColor = true;
            this.butt_go.Click += new System.EventHandler(this.butt_go_Click);
            // 
            // button_cos
            // 
            this.button_cos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cos.BackgroundImage = global::Fizzler.Properties.Resources.cart;
            this.button_cos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cos.FlatAppearance.BorderSize = 0;
            this.button_cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cos.ForeColor = System.Drawing.Color.Transparent;
            this.button_cos.Location = new System.Drawing.Point(1096, 0);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(40, 40);
            this.button_cos.TabIndex = 5;
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_login
            // 
            this.button_login.BackgroundImage = global::Fizzler.Properties.Resources.icon;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.ForeColor = System.Drawing.Color.Transparent;
            this.button_login.Location = new System.Drawing.Point(1144, 0);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(40, 40);
            this.button_login.TabIndex = 4;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Fizzler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 723);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.top_panel);
            this.MinimumSize = new System.Drawing.Size(1200, 762);
            this.Name = "Fizzler";
            this.Text = "Fizzler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fizzler_FormClosing);
            this.Load += new System.EventHandler(this.Fizzler_Load);
            this.SizeChanged += new System.EventHandler(this.Fizzler_SizeChanged);
            this.top_panel.ResumeLayout(false);
            this.main_panel.ResumeLayout(false);
            this.side_panel.ResumeLayout(false);
            this.side_panel.PerformLayout();
            this.groupBox_fructe.ResumeLayout(false);
            this.groupBox_fructe.PerformLayout();
            this.groupBox_categorii.ResumeLayout(false);
            this.groupBox_categorii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label label_sortare;
        private System.Windows.Forms.ComboBox comboBox_sortare;
        private System.Windows.Forms.Label label_zahar;
        private System.Windows.Forms.ComboBox comboBox_zahar;
        private System.Windows.Forms.Label label_filtrare;
        private System.Windows.Forms.GroupBox groupBox_fructe;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.GroupBox groupBox_categorii;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butt_go;
        private System.Windows.Forms.Button clear_button2;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Button button_sterge_suc;
        private System.Windows.Forms.Button button_adauga_suc;
        private System.Windows.Forms.Button button_rapoarte;
        private System.Windows.Forms.Button button_sucuri;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_login;
    }
}

