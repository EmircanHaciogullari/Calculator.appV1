﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EkranLabel1 = new System.Windows.Forms.Label();
            this.rakam1button = new System.Windows.Forms.Button();
            this.rakam2button = new System.Windows.Forms.Button();
            this.rakam3button = new System.Windows.Forms.Button();
            this.rakam6button = new System.Windows.Forms.Button();
            this.rakam5button = new System.Windows.Forms.Button();
            this.rakam4button = new System.Windows.Forms.Button();
            this.eşittirbutton = new System.Windows.Forms.Button();
            this.rakam0button = new System.Windows.Forms.Button();
            this.temizleCbutton = new System.Windows.Forms.Button();
            this.rakam9button = new System.Windows.Forms.Button();
            this.rakam8button = new System.Windows.Forms.Button();
            this.rakam7button = new System.Windows.Forms.Button();
            this.bölmebutton = new System.Windows.Forms.Button();
            this.çarpmabutton = new System.Windows.Forms.Button();
            this.eksibutton = new System.Windows.Forms.Button();
            this.artıbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EkranLabel1
            // 
            this.EkranLabel1.BackColor = System.Drawing.Color.White;
            this.EkranLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkranLabel1.Location = new System.Drawing.Point(12, 9);
            this.EkranLabel1.Name = "EkranLabel1";
            this.EkranLabel1.Size = new System.Drawing.Size(333, 74);
            this.EkranLabel1.TabIndex = 0;
            this.EkranLabel1.Text = "0";
            this.EkranLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rakam1button
            // 
            this.rakam1button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1button.ForeColor = System.Drawing.Color.White;
            this.rakam1button.Location = new System.Drawing.Point(12, 98);
            this.rakam1button.Name = "rakam1button";
            this.rakam1button.Size = new System.Drawing.Size(75, 75);
            this.rakam1button.TabIndex = 1;
            this.rakam1button.Text = "1";
            this.rakam1button.UseVisualStyleBackColor = false;
            this.rakam1button.Click += new System.EventHandler(this.rakam1button_Click);
            // 
            // rakam2button
            // 
            this.rakam2button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2button.ForeColor = System.Drawing.Color.White;
            this.rakam2button.Location = new System.Drawing.Point(93, 98);
            this.rakam2button.Name = "rakam2button";
            this.rakam2button.Size = new System.Drawing.Size(75, 75);
            this.rakam2button.TabIndex = 2;
            this.rakam2button.Text = "2";
            this.rakam2button.UseVisualStyleBackColor = false;
            this.rakam2button.Click += new System.EventHandler(this.rakam2button_Click);
            // 
            // rakam3button
            // 
            this.rakam3button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3button.ForeColor = System.Drawing.Color.White;
            this.rakam3button.Location = new System.Drawing.Point(174, 98);
            this.rakam3button.Name = "rakam3button";
            this.rakam3button.Size = new System.Drawing.Size(75, 75);
            this.rakam3button.TabIndex = 3;
            this.rakam3button.Text = "3";
            this.rakam3button.UseVisualStyleBackColor = false;
            this.rakam3button.Click += new System.EventHandler(this.rakam3button_Click);
            // 
            // rakam6button
            // 
            this.rakam6button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6button.ForeColor = System.Drawing.Color.White;
            this.rakam6button.Location = new System.Drawing.Point(174, 179);
            this.rakam6button.Name = "rakam6button";
            this.rakam6button.Size = new System.Drawing.Size(75, 75);
            this.rakam6button.TabIndex = 6;
            this.rakam6button.Text = "6";
            this.rakam6button.UseVisualStyleBackColor = false;
            this.rakam6button.Click += new System.EventHandler(this.rakam6button_Click);
            // 
            // rakam5button
            // 
            this.rakam5button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5button.ForeColor = System.Drawing.Color.White;
            this.rakam5button.Location = new System.Drawing.Point(93, 179);
            this.rakam5button.Name = "rakam5button";
            this.rakam5button.Size = new System.Drawing.Size(75, 75);
            this.rakam5button.TabIndex = 5;
            this.rakam5button.Text = "5";
            this.rakam5button.UseVisualStyleBackColor = false;
            this.rakam5button.Click += new System.EventHandler(this.rakam5button_Click);
            // 
            // rakam4button
            // 
            this.rakam4button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4button.ForeColor = System.Drawing.Color.White;
            this.rakam4button.Location = new System.Drawing.Point(12, 179);
            this.rakam4button.Name = "rakam4button";
            this.rakam4button.Size = new System.Drawing.Size(75, 75);
            this.rakam4button.TabIndex = 4;
            this.rakam4button.Text = "4";
            this.rakam4button.UseVisualStyleBackColor = false;
            this.rakam4button.Click += new System.EventHandler(this.rakam4button_Click);
            // 
            // eşittirbutton
            // 
            this.eşittirbutton.BackColor = System.Drawing.Color.DarkSalmon;
            this.eşittirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eşittirbutton.Location = new System.Drawing.Point(174, 341);
            this.eşittirbutton.Name = "eşittirbutton";
            this.eşittirbutton.Size = new System.Drawing.Size(75, 75);
            this.eşittirbutton.TabIndex = 12;
            this.eşittirbutton.Text = "=";
            this.eşittirbutton.UseVisualStyleBackColor = false;
            this.eşittirbutton.Click += new System.EventHandler(this.eşittirbutton_Click);
            // 
            // rakam0button
            // 
            this.rakam0button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam0button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0button.ForeColor = System.Drawing.Color.White;
            this.rakam0button.Location = new System.Drawing.Point(93, 341);
            this.rakam0button.Name = "rakam0button";
            this.rakam0button.Size = new System.Drawing.Size(75, 75);
            this.rakam0button.TabIndex = 11;
            this.rakam0button.Text = "0";
            this.rakam0button.UseVisualStyleBackColor = false;
            this.rakam0button.Click += new System.EventHandler(this.rakam0button_Click);
            // 
            // temizleCbutton
            // 
            this.temizleCbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.temizleCbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleCbutton.Location = new System.Drawing.Point(12, 341);
            this.temizleCbutton.Name = "temizleCbutton";
            this.temizleCbutton.Size = new System.Drawing.Size(75, 75);
            this.temizleCbutton.TabIndex = 10;
            this.temizleCbutton.Text = "C";
            this.temizleCbutton.UseVisualStyleBackColor = false;
            this.temizleCbutton.Click += new System.EventHandler(this.temizleCbutton_Click);
            // 
            // rakam9button
            // 
            this.rakam9button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9button.ForeColor = System.Drawing.Color.White;
            this.rakam9button.Location = new System.Drawing.Point(174, 260);
            this.rakam9button.Name = "rakam9button";
            this.rakam9button.Size = new System.Drawing.Size(75, 75);
            this.rakam9button.TabIndex = 9;
            this.rakam9button.Text = "9";
            this.rakam9button.UseVisualStyleBackColor = false;
            this.rakam9button.Click += new System.EventHandler(this.rakam9button_Click);
            // 
            // rakam8button
            // 
            this.rakam8button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8button.ForeColor = System.Drawing.Color.White;
            this.rakam8button.Location = new System.Drawing.Point(93, 260);
            this.rakam8button.Name = "rakam8button";
            this.rakam8button.Size = new System.Drawing.Size(75, 75);
            this.rakam8button.TabIndex = 8;
            this.rakam8button.Text = "8";
            this.rakam8button.UseVisualStyleBackColor = false;
            this.rakam8button.Click += new System.EventHandler(this.rakam8button_Click);
            // 
            // rakam7button
            // 
            this.rakam7button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rakam7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7button.ForeColor = System.Drawing.Color.White;
            this.rakam7button.Location = new System.Drawing.Point(12, 260);
            this.rakam7button.Name = "rakam7button";
            this.rakam7button.Size = new System.Drawing.Size(75, 75);
            this.rakam7button.TabIndex = 7;
            this.rakam7button.Text = "7";
            this.rakam7button.UseVisualStyleBackColor = false;
            this.rakam7button.Click += new System.EventHandler(this.rakam7button_Click);
            // 
            // bölmebutton
            // 
            this.bölmebutton.BackColor = System.Drawing.Color.Gainsboro;
            this.bölmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölmebutton.Location = new System.Drawing.Point(270, 341);
            this.bölmebutton.Name = "bölmebutton";
            this.bölmebutton.Size = new System.Drawing.Size(75, 75);
            this.bölmebutton.TabIndex = 16;
            this.bölmebutton.Text = "÷";
            this.bölmebutton.UseVisualStyleBackColor = false;
            this.bölmebutton.Click += new System.EventHandler(this.bölmebutton_Click);
            // 
            // çarpmabutton
            // 
            this.çarpmabutton.BackColor = System.Drawing.Color.Gainsboro;
            this.çarpmabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çarpmabutton.Location = new System.Drawing.Point(270, 260);
            this.çarpmabutton.Name = "çarpmabutton";
            this.çarpmabutton.Size = new System.Drawing.Size(75, 75);
            this.çarpmabutton.TabIndex = 15;
            this.çarpmabutton.Text = "x";
            this.çarpmabutton.UseVisualStyleBackColor = false;
            this.çarpmabutton.Click += new System.EventHandler(this.çarpmabutton_Click);
            // 
            // eksibutton
            // 
            this.eksibutton.BackColor = System.Drawing.Color.Gainsboro;
            this.eksibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksibutton.Location = new System.Drawing.Point(270, 179);
            this.eksibutton.Name = "eksibutton";
            this.eksibutton.Size = new System.Drawing.Size(75, 75);
            this.eksibutton.TabIndex = 14;
            this.eksibutton.Text = "-";
            this.eksibutton.UseVisualStyleBackColor = false;
            this.eksibutton.Click += new System.EventHandler(this.eksibutton_Click);
            // 
            // artıbutton
            // 
            this.artıbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.artıbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artıbutton.Location = new System.Drawing.Point(270, 98);
            this.artıbutton.Name = "artıbutton";
            this.artıbutton.Size = new System.Drawing.Size(75, 75);
            this.artıbutton.TabIndex = 13;
            this.artıbutton.Text = "+";
            this.artıbutton.UseVisualStyleBackColor = false;
            this.artıbutton.Click += new System.EventHandler(this.artıbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.bölmebutton);
            this.Controls.Add(this.çarpmabutton);
            this.Controls.Add(this.eksibutton);
            this.Controls.Add(this.artıbutton);
            this.Controls.Add(this.eşittirbutton);
            this.Controls.Add(this.rakam0button);
            this.Controls.Add(this.temizleCbutton);
            this.Controls.Add(this.rakam9button);
            this.Controls.Add(this.rakam8button);
            this.Controls.Add(this.rakam7button);
            this.Controls.Add(this.rakam6button);
            this.Controls.Add(this.rakam5button);
            this.Controls.Add(this.rakam4button);
            this.Controls.Add(this.rakam3button);
            this.Controls.Add(this.rakam2button);
            this.Controls.Add(this.rakam1button);
            this.Controls.Add(this.EkranLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorV1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EkranLabel1;
        private System.Windows.Forms.Button rakam1button;
        private System.Windows.Forms.Button rakam2button;
        private System.Windows.Forms.Button rakam3button;
        private System.Windows.Forms.Button rakam6button;
        private System.Windows.Forms.Button rakam5button;
        private System.Windows.Forms.Button rakam4button;
        private System.Windows.Forms.Button eşittirbutton;
        private System.Windows.Forms.Button rakam0button;
        private System.Windows.Forms.Button temizleCbutton;
        private System.Windows.Forms.Button rakam9button;
        private System.Windows.Forms.Button rakam8button;
        private System.Windows.Forms.Button rakam7button;
        private System.Windows.Forms.Button bölmebutton;
        private System.Windows.Forms.Button çarpmabutton;
        private System.Windows.Forms.Button eksibutton;
        private System.Windows.Forms.Button artıbutton;
    }
}

