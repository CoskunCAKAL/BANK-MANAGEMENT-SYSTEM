﻿namespace Prolab2._3
{
    partial class girismüdür
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.tcnotxt = new System.Windows.Forms.TextBox();
            this.müdürgirisbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sifretxt);
            this.groupBox1.Controls.Add(this.tcnotxt);
            this.groupBox1.Controls.Add(this.müdürgirisbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(88, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müdür Girişi";
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(63, 172);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(100, 23);
            this.sifretxt.TabIndex = 4;
            // 
            // tcnotxt
            // 
            this.tcnotxt.Location = new System.Drawing.Point(63, 102);
            this.tcnotxt.Name = "tcnotxt";
            this.tcnotxt.Size = new System.Drawing.Size(100, 23);
            this.tcnotxt.TabIndex = 3;
            this.tcnotxt.TextChanged += new System.EventHandler(this.tcnotxt_TextChanged);
            // 
            // müdürgirisbtn
            // 
            this.müdürgirisbtn.Location = new System.Drawing.Point(63, 217);
            this.müdürgirisbtn.Name = "müdürgirisbtn";
            this.müdürgirisbtn.Size = new System.Drawing.Size(100, 23);
            this.müdürgirisbtn.TabIndex = 2;
            this.müdürgirisbtn.Text = "Giriş";
            this.müdürgirisbtn.UseVisualStyleBackColor = true;
            this.müdürgirisbtn.Click += new System.EventHandler(this.müdürgirisbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No";
            // 
            // girismüdür
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "girismüdür";
            this.Text = "girismüdür";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox sifretxt;
        private TextBox tcnotxt;
        private Button müdürgirisbtn;
        private Label label2;
        private Label label1;
    }
}