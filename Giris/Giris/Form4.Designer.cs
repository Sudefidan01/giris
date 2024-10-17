namespace Giris
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnÇıkar = new System.Windows.Forms.Button();
            this.btnÇarp = new System.Windows.Forms.Button();
            this.btnBöl = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(279, 44);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(82, 55);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnÇıkar
            // 
            this.btnÇıkar.Location = new System.Drawing.Point(382, 44);
            this.btnÇıkar.Name = "btnÇıkar";
            this.btnÇıkar.Size = new System.Drawing.Size(82, 55);
            this.btnÇıkar.TabIndex = 5;
            this.btnÇıkar.Text = "Çıkar";
            this.btnÇıkar.UseVisualStyleBackColor = true;
            this.btnÇıkar.Click += new System.EventHandler(this.btnÇıkar_Click);
            // 
            // btnÇarp
            // 
            this.btnÇarp.Location = new System.Drawing.Point(279, 125);
            this.btnÇarp.Name = "btnÇarp";
            this.btnÇarp.Size = new System.Drawing.Size(82, 55);
            this.btnÇarp.TabIndex = 6;
            this.btnÇarp.Text = "Çarp";
            this.btnÇarp.UseVisualStyleBackColor = true;
            this.btnÇarp.Click += new System.EventHandler(this.btnÇarp_Click);
            // 
            // btnBöl
            // 
            this.btnBöl.Location = new System.Drawing.Point(382, 125);
            this.btnBöl.Name = "btnBöl";
            this.btnBöl.Size = new System.Drawing.Size(82, 55);
            this.btnBöl.TabIndex = 7;
            this.btnBöl.Text = "Böl";
            this.btnBöl.UseVisualStyleBackColor = true;
            this.btnBöl.Click += new System.EventHandler(this.btnBöl_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(49, 240);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(411, 137);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBöl);
            this.Controls.Add(this.btnÇarp);
            this.Controls.Add(this.btnÇıkar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnÇıkar;
        private System.Windows.Forms.Button btnÇarp;
        private System.Windows.Forms.Button btnBöl;
        private System.Windows.Forms.Label lblSonuc;
    }
}