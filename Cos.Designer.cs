namespace Fizzler
{
    partial class Cos
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_cumpara = new System.Windows.Forms.Button();
            this.textBox_cantitate_totala = new System.Windows.Forms.MaskedTextBox();
            this.textBox_pret_total = new System.Windows.Forms.MaskedTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Controls.Add(this.button_cumpara);
            this.panel11.Controls.Add(this.textBox_cantitate_totala);
            this.panel11.Controls.Add(this.textBox_pret_total);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(919, 100);
            this.panel11.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Fizzler.Properties.Resources.shoppingcart1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 94);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button_cumpara
            // 
            this.button_cumpara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cumpara.BackgroundImage = global::Fizzler.Properties.Resources.creditcard1;
            this.button_cumpara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cumpara.FlatAppearance.BorderSize = 0;
            this.button_cumpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cumpara.Location = new System.Drawing.Point(850, 19);
            this.button_cumpara.Name = "button_cumpara";
            this.button_cumpara.Size = new System.Drawing.Size(57, 57);
            this.button_cumpara.TabIndex = 8;
            this.button_cumpara.UseVisualStyleBackColor = true;
            this.button_cumpara.Click += new System.EventHandler(this.button_cumpara_Click);
            // 
            // textBox_cantitate_totala
            // 
            this.textBox_cantitate_totala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cantitate_totala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.textBox_cantitate_totala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_cantitate_totala.Location = new System.Drawing.Point(319, 19);
            this.textBox_cantitate_totala.Name = "textBox_cantitate_totala";
            this.textBox_cantitate_totala.ReadOnly = true;
            this.textBox_cantitate_totala.Size = new System.Drawing.Size(510, 23);
            this.textBox_cantitate_totala.TabIndex = 7;
            this.textBox_cantitate_totala.Text = "Cantitate produse: 2523 ";
            this.textBox_cantitate_totala.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_pret_total
            // 
            this.textBox_pret_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pret_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.textBox_pret_total.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_pret_total.Location = new System.Drawing.Point(319, 47);
            this.textBox_pret_total.Name = "textBox_pret_total";
            this.textBox_pret_total.ReadOnly = true;
            this.textBox_pret_total.Size = new System.Drawing.Size(510, 29);
            this.textBox_pret_total.TabIndex = 6;
            this.textBox_pret_total.Text = "Preț total: 2352315 lei";
            this.textBox_pret_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 100);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(919, 425);
            this.panel.TabIndex = 1;
            // 
            // Cos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(919, 525);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel11);
            this.MinimumSize = new System.Drawing.Size(935, 434);
            this.Name = "Cos";
            this.Text = "Cos";
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_cumpara;
        private System.Windows.Forms.MaskedTextBox textBox_cantitate_totala;
        private System.Windows.Forms.MaskedTextBox textBox_pret_total;
        private System.Windows.Forms.Panel panel;
    }
}