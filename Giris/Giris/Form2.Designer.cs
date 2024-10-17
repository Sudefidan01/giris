namespace Giris
{
    partial class Form2
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
            this.btnTextBoxOku = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnLabelOku = new System.Windows.Forms.Button();
            this.lblYazi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTextBoxOku
            // 
            this.btnTextBoxOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTextBoxOku.Location = new System.Drawing.Point(428, 30);
            this.btnTextBoxOku.Name = "btnTextBoxOku";
            this.btnTextBoxOku.Size = new System.Drawing.Size(130, 80);
            this.btnTextBoxOku.TabIndex = 0;
            this.btnTextBoxOku.Text = "TextBox Oku";
            this.btnTextBoxOku.UseVisualStyleBackColor = true;
            this.btnTextBoxOku.Click += new System.EventHandler(this.btnTextBoxOku_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(581, 30);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(130, 80);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnLabelOku
            // 
            this.btnLabelOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLabelOku.Location = new System.Drawing.Point(497, 140);
            this.btnLabelOku.Name = "btnLabelOku";
            this.btnLabelOku.Size = new System.Drawing.Size(130, 80);
            this.btnLabelOku.TabIndex = 2;
            this.btnLabelOku.Text = "Label OKu";
            this.btnLabelOku.UseVisualStyleBackColor = true;
            this.btnLabelOku.Click += new System.EventHandler(this.btnLabelOku_Click);
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblYazi.Location = new System.Drawing.Point(189, 306);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(414, 55);
            this.lblYazi.TabIndex = 3;
            this.lblYazi.Text = "Bu bir yazı alanıdır";
            this.lblYazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 90);
            this.textBox1.MaxLength = 55150;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.btnLabelOku);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnTextBoxOku);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTextBoxOku;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnLabelOku;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.TextBox textBox1;
    }
}