﻿namespace KissPatrikbeadando
{
    partial class Rendeles
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBoxMegrendelheto = new System.Windows.Forms.ListBox();
            this.listBoxMegrendelt = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Megrendelő neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Megrendelő címe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Megrendhető termékek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Megrendelt termékek";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 5;
            // 
            // listBoxMegrendelheto
            // 
            this.listBoxMegrendelheto.FormattingEnabled = true;
            this.listBoxMegrendelheto.Items.AddRange(new object[] {
            "Alma(1kg)",
            "Áfonya(1kg)",
            "Cseresznye(1kg)",
            "Eper(1kg)",
            "Görögdinnye(1kg)",
            "Meggy(1kg)",
            "Őszibarack(1kg)",
            "Sárgabarack(1kg)",
            "Sárgadinnye(1kg)",
            "Szilva(1kg)"});
            this.listBoxMegrendelheto.Location = new System.Drawing.Point(274, 71);
            this.listBoxMegrendelheto.Name = "listBoxMegrendelheto";
            this.listBoxMegrendelheto.Size = new System.Drawing.Size(133, 251);
            this.listBoxMegrendelheto.TabIndex = 6;
            // 
            // listBoxMegrendelt
            // 
            this.listBoxMegrendelt.FormattingEnabled = true;
            this.listBoxMegrendelt.Location = new System.Drawing.Point(575, 71);
            this.listBoxMegrendelt.Name = "listBoxMegrendelt";
            this.listBoxMegrendelt.Size = new System.Drawing.Size(133, 251);
            this.listBoxMegrendelt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(436, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 63);
            this.button2.TabIndex = 11;
            this.button2.Text = "Töröl";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 81);
            this.button3.TabIndex = 12;
            this.button3.Text = "Vissza";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 81);
            this.button4.TabIndex = 13;
            this.button4.Text = "Megrendel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Rendeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMegrendelt);
            this.Controls.Add(this.listBoxMegrendelheto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rendeles";
            this.Text = "Nyeremenyjatek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBoxMegrendelheto;
        private System.Windows.Forms.ListBox listBoxMegrendelt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}