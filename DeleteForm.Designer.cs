namespace Fizzler
{
    partial class DeleteForm
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
            this.panel_suc = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_cautare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_suc
            // 
            this.panel_suc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.panel_suc.Location = new System.Drawing.Point(34, 170);
            this.panel_suc.Name = "panel_suc";
            this.panel_suc.Size = new System.Drawing.Size(912, 198);
            this.panel_suc.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(371, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(481, 115);
            this.textBox_ID.MaxLength = 6;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(184, 29);
            this.textBox_ID.TabIndex = 2;
            this.textBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(856, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Anulează";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.button_confirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_confirm.ForeColor = System.Drawing.Color.White;
            this.button_confirm.Location = new System.Drawing.Point(760, 397);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(90, 35);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Fizzler.Properties.Resources.del;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(34, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_cautare
            // 
            this.button_cautare.BackgroundImage = global::Fizzler.Properties.Resources.lupa;
            this.button_cautare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cautare.Location = new System.Drawing.Point(671, 115);
            this.button_cautare.Name = "button_cautare";
            this.button_cautare.Size = new System.Drawing.Size(33, 29);
            this.button_cautare.TabIndex = 6;
            this.button_cautare.UseVisualStyleBackColor = true;
            this.button_cautare.Click += new System.EventHandler(this.button_cautare_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(993, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_cautare);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_suc);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximumSize = new System.Drawing.Size(1009, 568);
            this.MinimumSize = new System.Drawing.Size(1009, 568);
            this.Name = "DeleteForm";
            this.Text = "Ștergere suc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_suc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cautare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}