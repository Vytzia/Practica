namespace Fizzler
{
    partial class Cantitate_suc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cumpara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(45, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceți cantiatatea (>=100; <=10000)";
            // 
            // button_cumpara
            // 
            this.button_cumpara.BackgroundImage = global::Fizzler.Properties.Resources.go;
            this.button_cumpara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_cumpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_cumpara.Location = new System.Drawing.Point(229, 72);
            this.button_cumpara.Name = "button_cumpara";
            this.button_cumpara.Size = new System.Drawing.Size(32, 29);
            this.button_cumpara.TabIndex = 1;
            this.button_cumpara.UseVisualStyleBackColor = true;
            this.button_cumpara.Click += new System.EventHandler(this.button_cumpara_Click);
            this.button_cumpara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_cumpara_KeyDown);
            // 
            // Cantitate_suc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(304, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cumpara);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(320, 182);
            this.MinimumSize = new System.Drawing.Size(320, 182);
            this.Name = "Cantitate_suc";
            this.Text = "Cantitate_suc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_cumpara;
        private System.Windows.Forms.Label label1;
    }
}