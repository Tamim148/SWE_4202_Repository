
namespace Lab10
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SearchUserEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Phone2Bar = new System.Windows.Forms.Label();
            this.Phone1Bar = new System.Windows.Forms.Label();
            this.StateBar = new System.Windows.Forms.Label();
            this.CountyBar = new System.Windows.Forms.Label();
            this.AddressBar = new System.Windows.Forms.Label();
            this.NameBar1 = new System.Windows.Forms.Label();
            this.CityBar = new System.Windows.Forms.Label();
            this.ZipBar = new System.Windows.Forms.Label();
            this.NameBar2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 420);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SearchUserEmail
            // 
            this.SearchUserEmail.Location = new System.Drawing.Point(601, 41);
            this.SearchUserEmail.Name = "SearchUserEmail";
            this.SearchUserEmail.Size = new System.Drawing.Size(187, 20);
            this.SearchUserEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "County";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Zip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Phone 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone 2";
            // 
            // Phone2Bar
            // 
            this.Phone2Bar.AutoSize = true;
            this.Phone2Bar.Location = new System.Drawing.Point(617, 365);
            this.Phone2Bar.Name = "Phone2Bar";
            this.Phone2Bar.Size = new System.Drawing.Size(60, 13);
            this.Phone2Bar.TabIndex = 19;
            this.Phone2Bar.Text = "Phone2Bar";
            // 
            // Phone1Bar
            // 
            this.Phone1Bar.AutoSize = true;
            this.Phone1Bar.Location = new System.Drawing.Point(617, 337);
            this.Phone1Bar.Name = "Phone1Bar";
            this.Phone1Bar.Size = new System.Drawing.Size(60, 13);
            this.Phone1Bar.TabIndex = 18;
            this.Phone1Bar.Text = "Phone1Bar";
            // 
            // StateBar
            // 
            this.StateBar.AutoSize = true;
            this.StateBar.Location = new System.Drawing.Point(617, 282);
            this.StateBar.Name = "StateBar";
            this.StateBar.Size = new System.Drawing.Size(48, 13);
            this.StateBar.TabIndex = 17;
            this.StateBar.Text = "StateBar";
            // 
            // CountyBar
            // 
            this.CountyBar.AutoSize = true;
            this.CountyBar.Location = new System.Drawing.Point(617, 255);
            this.CountyBar.Name = "CountyBar";
            this.CountyBar.Size = new System.Drawing.Size(56, 13);
            this.CountyBar.TabIndex = 16;
            this.CountyBar.Text = "CountyBar";
            // 
            // AddressBar
            // 
            this.AddressBar.AutoSize = true;
            this.AddressBar.Location = new System.Drawing.Point(617, 196);
            this.AddressBar.Name = "AddressBar";
            this.AddressBar.Size = new System.Drawing.Size(61, 13);
            this.AddressBar.TabIndex = 15;
            this.AddressBar.Text = "AddressBar";
            // 
            // NameBar1
            // 
            this.NameBar1.AutoSize = true;
            this.NameBar1.Location = new System.Drawing.Point(617, 129);
            this.NameBar1.Name = "NameBar1";
            this.NameBar1.Size = new System.Drawing.Size(57, 13);
            this.NameBar1.TabIndex = 13;
            this.NameBar1.Text = "NameBar1";
            // 
            // CityBar
            // 
            this.CityBar.AutoSize = true;
            this.CityBar.Location = new System.Drawing.Point(617, 225);
            this.CityBar.Name = "CityBar";
            this.CityBar.Size = new System.Drawing.Size(40, 13);
            this.CityBar.TabIndex = 20;
            this.CityBar.Text = "CityBar";
            // 
            // ZipBar
            // 
            this.ZipBar.AutoSize = true;
            this.ZipBar.Location = new System.Drawing.Point(617, 307);
            this.ZipBar.Name = "ZipBar";
            this.ZipBar.Size = new System.Drawing.Size(38, 13);
            this.ZipBar.TabIndex = 21;
            this.ZipBar.Text = "ZipBar";
            // 
            // NameBar2
            // 
            this.NameBar2.AutoSize = true;
            this.NameBar2.Location = new System.Drawing.Point(710, 129);
            this.NameBar2.Name = "NameBar2";
            this.NameBar2.Size = new System.Drawing.Size(57, 13);
            this.NameBar2.TabIndex = 22;
            this.NameBar2.Text = "NameBar2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameBar2);
            this.Controls.Add(this.ZipBar);
            this.Controls.Add(this.CityBar);
            this.Controls.Add(this.Phone2Bar);
            this.Controls.Add(this.Phone1Bar);
            this.Controls.Add(this.StateBar);
            this.Controls.Add(this.CountyBar);
            this.Controls.Add(this.AddressBar);
            this.Controls.Add(this.NameBar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchUserEmail);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox SearchUserEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Phone2Bar;
        private System.Windows.Forms.Label Phone1Bar;
        private System.Windows.Forms.Label StateBar;
        private System.Windows.Forms.Label CountyBar;
        private System.Windows.Forms.Label AddressBar;
        private System.Windows.Forms.Label NameBar1;
        private System.Windows.Forms.Label CityBar;
        private System.Windows.Forms.Label ZipBar;
        private System.Windows.Forms.Label NameBar2;
    }
}

