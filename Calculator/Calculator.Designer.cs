using System;
using System.Windows.Forms;

namespace laborator.net
{
    partial class Calculator
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
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.value_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(41, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 34);
            this.textBox1.TabIndex = 0;
            
            
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(41, 118);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(47, 41);
            this.n1.TabIndex = 1;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(94, 118);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(47, 41);
            this.n2.TabIndex = 2;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(147, 118);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(47, 41);
            this.n3.TabIndex = 3;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(41, 165);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(47, 41);
            this.n4.TabIndex = 4;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(94, 165);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(47, 41);
            this.n5.TabIndex = 5;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(147, 165);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(47, 41);
            this.n6.TabIndex = 6;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(41, 212);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(47, 41);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(94, 212);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(47, 41);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(147, 212);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(47, 41);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.Location = new System.Drawing.Point(94, 259);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(47, 41);
            this.n0.TabIndex = 10;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(200, 118);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(47, 41);
            this.badd.TabIndex = 11;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bdiv
            // 
            this.bdiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdiv.Location = new System.Drawing.Point(200, 259);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(47, 41);
            this.bdiv.TabIndex = 12;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            this.bdiv.Click += new System.EventHandler(this.bdiv_Click);
            // 
            // bmul
            // 
            this.bmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmul.Location = new System.Drawing.Point(200, 212);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(47, 41);
            this.bmul.TabIndex = 13;
            this.bmul.Text = "*";
            this.bmul.UseVisualStyleBackColor = true;
            this.bmul.Click += new System.EventHandler(this.bmul_Click);
            // 
            // bsub
            // 
            this.bsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.Location = new System.Drawing.Point(200, 165);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(47, 41);
            this.bsub.TabIndex = 14;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            this.bsub.Click += new System.EventHandler(this.bsub_Click);
            // 
            // deci
            // 
            this.deci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deci.Location = new System.Drawing.Point(41, 259);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(47, 41);
            this.deci.TabIndex = 15;
            this.deci.Text = ".";
            this.deci.UseVisualStyleBackColor = true;
            this.deci.Click += new System.EventHandler(this.deci_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(147, 259);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(47, 41);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // eq
            // 
            this.eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq.Location = new System.Drawing.Point(121, 306);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(47, 41);
            this.eq.TabIndex = 17;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = true;
            this.eq.Click += new System.EventHandler(this.eq_Click);
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(42, 31);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(0, 17);
            this.value_label.TabIndex = 18;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 382);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.eq);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
            this.ActiveControl = null;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.Label value_label;
    }
}

