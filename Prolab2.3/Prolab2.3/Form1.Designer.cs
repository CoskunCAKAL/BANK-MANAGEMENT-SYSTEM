namespace Prolab2._3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.müdürgiris = new System.Windows.Forms.LinkLabel();
            this.temsilcigiris = new System.Windows.Forms.LinkLabel();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.tcnotxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ekletxt = new System.Windows.Forms.Button();
            this.kytsfr = new System.Windows.Forms.TextBox();
            this.kytpst = new System.Windows.Forms.TextBox();
            this.kyttcn = new System.Windows.Forms.TextBox();
            this.kyttlfn = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.müdürgiris);
            this.groupBox1.Controls.Add(this.temsilcigiris);
            this.groupBox1.Controls.Add(this.sifretxt);
            this.groupBox1.Controls.Add(this.tcnotxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // müdürgiris
            // 
            this.müdürgiris.AutoSize = true;
            this.müdürgiris.Location = new System.Drawing.Point(123, 268);
            this.müdürgiris.Name = "müdürgiris";
            this.müdürgiris.Size = new System.Drawing.Size(72, 15);
            this.müdürgiris.TabIndex = 6;
            this.müdürgiris.TabStop = true;
            this.müdürgiris.Text = "Müdür Girişi";
            this.müdürgiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.müdürgiris_LinkClicked);
            // 
            // temsilcigiris
            // 
            this.temsilcigiris.AutoSize = true;
            this.temsilcigiris.Location = new System.Drawing.Point(21, 268);
            this.temsilcigiris.Name = "temsilcigiris";
            this.temsilcigiris.Size = new System.Drawing.Size(78, 15);
            this.temsilcigiris.TabIndex = 5;
            this.temsilcigiris.TabStop = true;
            this.temsilcigiris.Text = "Temsilci Girişi";
            this.temsilcigiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.temsilcigiris_LinkClicked);
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ekletxt);
            this.groupBox2.Controls.Add(this.kytsfr);
            this.groupBox2.Controls.Add(this.kytpst);
            this.groupBox2.Controls.Add(this.kyttcn);
            this.groupBox2.Controls.Add(this.kyttlfn);
            this.groupBox2.Controls.Add(this.txtad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(391, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 295);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Ol";
            // 
            // ekletxt
            // 
            this.ekletxt.Location = new System.Drawing.Point(112, 223);
            this.ekletxt.Name = "ekletxt";
            this.ekletxt.Size = new System.Drawing.Size(100, 25);
            this.ekletxt.TabIndex = 14;
            this.ekletxt.Text = "Ekle";
            this.ekletxt.UseVisualStyleBackColor = true;
            this.ekletxt.Click += new System.EventHandler(this.ekletxt_Click);
            // 
            // kytsfr
            // 
            this.kytsfr.Location = new System.Drawing.Point(112, 194);
            this.kytsfr.Name = "kytsfr";
            this.kytsfr.Size = new System.Drawing.Size(100, 23);
            this.kytsfr.TabIndex = 13;
            // 
            // kytpst
            // 
            this.kytpst.Location = new System.Drawing.Point(112, 155);
            this.kytpst.Name = "kytpst";
            this.kytpst.Size = new System.Drawing.Size(100, 23);
            this.kytpst.TabIndex = 11;
            // 
            // kyttcn
            // 
            this.kyttcn.Location = new System.Drawing.Point(112, 116);
            this.kyttcn.Name = "kyttcn";
            this.kyttcn.Size = new System.Drawing.Size(100, 23);
            this.kyttcn.TabIndex = 10;
            // 
            // kyttlfn
            // 
            this.kyttlfn.Location = new System.Drawing.Point(112, 77);
            this.kyttlfn.Name = "kyttlfn";
            this.kyttlfn.Size = new System.Drawing.Size(100, 23);
            this.kyttlfn.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(112, 38);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 23);
            this.txtad.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "TC No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox sifretxt;
        private TextBox tcnotxt;
        private GroupBox groupBox2;
        private TextBox kytsfr;
        private TextBox kytpst;
        private TextBox kyttcn;
        private TextBox kyttlfn;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button ekletxt;
        private TextBox txtad;
        private LinkLabel temsilcigiris;
        private LinkLabel müdürgiris;
    }
}