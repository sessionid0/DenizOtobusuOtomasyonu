
namespace HadoTestApp
{
    partial class HesKod
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_heskontrol = new System.Windows.Forms.Label();
            this.textBox_captcha = new System.Windows.Forms.TextBox();
            this.label_captcha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(93, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hes kodunuz:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(200, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(270, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mevcut HES kodunuz:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_heskontrol
            // 
            this.label_heskontrol.AutoSize = true;
            this.label_heskontrol.BackColor = System.Drawing.Color.Transparent;
            this.label_heskontrol.CausesValidation = false;
            this.label_heskontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_heskontrol.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_heskontrol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_heskontrol.Location = new System.Drawing.Point(192, 60);
            this.label_heskontrol.Name = "label_heskontrol";
            this.label_heskontrol.Size = new System.Drawing.Size(187, 46);
            this.label_heskontrol.TabIndex = 7;
            this.label_heskontrol.Text = "Lütfen aşağıdan \r\nyeni bir tane oluşturun.";
            // 
            // textBox_captcha
            // 
            this.textBox_captcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_captcha.Location = new System.Drawing.Point(196, 211);
            this.textBox_captcha.Name = "textBox_captcha";
            this.textBox_captcha.Size = new System.Drawing.Size(162, 22);
            this.textBox_captcha.TabIndex = 20;
            // 
            // label_captcha
            // 
            this.label_captcha.AutoSize = true;
            this.label_captcha.BackColor = System.Drawing.Color.Transparent;
            this.label_captcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_captcha.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_captcha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_captcha.Location = new System.Drawing.Point(106, 210);
            this.label_captcha.Name = "label_captcha";
            this.label_captcha.Size = new System.Drawing.Size(73, 23);
            this.label_captcha.TabIndex = 19;
            this.label_captcha.Text = "Captcha";
            this.label_captcha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HesKod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HadoTestApp.Properties.Resources.dotobus__2_;
            this.ClientSize = new System.Drawing.Size(458, 419);
            this.Controls.Add(this.textBox_captcha);
            this.Controls.Add(this.label_captcha);
            this.Controls.Add(this.label_heskontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HesKod";
            this.Text = "Hes Kodu Oluşturma ve Görüntüleme";
            this.Load += new System.EventHandler(this.HesKod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_heskontrol;
        private System.Windows.Forms.TextBox textBox_captcha;
        private System.Windows.Forms.Label label_captcha;
    }
}