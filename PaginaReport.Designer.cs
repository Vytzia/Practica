namespace Fizzler
{
    partial class PaginaReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_fructe = new System.Windows.Forms.Button();
            this.button_media_preturilor = new System.Windows.Forms.Button();
            this.button_vanzari = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(228)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.button_fructe);
            this.panel1.Controls.Add(this.button_media_preturilor);
            this.panel1.Controls.Add(this.button_vanzari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 762);
            this.panel1.TabIndex = 7;
            // 
            // button_fructe
            // 
            this.button_fructe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.button_fructe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_fructe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_fructe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_fructe.ForeColor = System.Drawing.Color.White;
            this.button_fructe.Location = new System.Drawing.Point(45, 100);
            this.button_fructe.Name = "button_fructe";
            this.button_fructe.Size = new System.Drawing.Size(191, 35);
            this.button_fructe.TabIndex = 8;
            this.button_fructe.Text = "Fructe utilizate";
            this.button_fructe.UseVisualStyleBackColor = false;
            this.button_fructe.Click += new System.EventHandler(this.button_fructe_Click);
            // 
            // button_media_preturilor
            // 
            this.button_media_preturilor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.button_media_preturilor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_media_preturilor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_media_preturilor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_media_preturilor.ForeColor = System.Drawing.Color.White;
            this.button_media_preturilor.Location = new System.Drawing.Point(45, 59);
            this.button_media_preturilor.Name = "button_media_preturilor";
            this.button_media_preturilor.Size = new System.Drawing.Size(191, 35);
            this.button_media_preturilor.TabIndex = 7;
            this.button_media_preturilor.Text = "Media prețurilor";
            this.button_media_preturilor.UseVisualStyleBackColor = false;
            this.button_media_preturilor.Click += new System.EventHandler(this.button_media_preturilor_Click);
            // 
            // button_vanzari
            // 
            this.button_vanzari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.button_vanzari.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_vanzari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vanzari.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_vanzari.ForeColor = System.Drawing.Color.White;
            this.button_vanzari.Location = new System.Drawing.Point(45, 18);
            this.button_vanzari.Name = "button_vanzari";
            this.button_vanzari.Size = new System.Drawing.Size(191, 35);
            this.button_vanzari.TabIndex = 6;
            this.button_vanzari.Text = "Vânzări";
            this.button_vanzari.UseVisualStyleBackColor = false;
            this.button_vanzari.Click += new System.EventHandler(this.button_vanzari_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(270, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 762);
            this.panel2.TabIndex = 8;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fizzler.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(270, 3, 3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 762);
            this.reportViewer1.TabIndex = 7;
            // 
            // PaginaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaginaReport";
            this.Size = new System.Drawing.Size(1200, 762);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_fructe;
        private System.Windows.Forms.Button button_media_preturilor;
        private System.Windows.Forms.Button button_vanzari;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
