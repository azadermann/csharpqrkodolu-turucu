
namespace QrKodOluşturucu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrtext = new System.Windows.Forms.TextBox();
            this.olustur = new System.Windows.Forms.Button();
            this.qrkod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrkod)).BeginInit();
            this.SuspendLayout();
            // 
            // qrtext
            // 
            this.qrtext.Location = new System.Drawing.Point(93, 88);
            this.qrtext.Name = "qrtext";
            this.qrtext.Size = new System.Drawing.Size(275, 23);
            this.qrtext.TabIndex = 0;
            // 
            // olustur
            // 
            this.olustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.olustur.Location = new System.Drawing.Point(93, 117);
            this.olustur.Name = "olustur";
            this.olustur.Size = new System.Drawing.Size(275, 28);
            this.olustur.TabIndex = 1;
            this.olustur.Text = "QR Kodu Oluştur";
            this.olustur.UseVisualStyleBackColor = true;
            this.olustur.Click += new System.EventHandler(this.olustur_Click);
            this.olustur.MouseEnter += new System.EventHandler(this.olustur_Click);
            // 
            // qrkod
            // 
            this.qrkod.Location = new System.Drawing.Point(93, 162);
            this.qrkod.Name = "qrkod";
            this.qrkod.Size = new System.Drawing.Size(275, 206);
            this.qrkod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrkod.TabIndex = 2;
            this.qrkod.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.qrkod);
            this.Controls.Add(this.olustur);
            this.Controls.Add(this.qrtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Kod Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qrtext;
        private System.Windows.Forms.Button olustur;
        private System.Windows.Forms.PictureBox qrkod;
    }
}

