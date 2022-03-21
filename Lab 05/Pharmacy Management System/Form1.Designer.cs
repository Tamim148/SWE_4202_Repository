namespace Pharmacy_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stockMedNameTextBox = new System.Windows.Forms.TextBox();
            this.stockMedQtyTextBox = new System.Windows.Forms.TextBox();
            this.stockMedUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.stockMedButton = new System.Windows.Forms.Button();
            this.buyMedQtyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buyMedButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.medAvailabilityButton = new System.Windows.Forms.Button();
            this.medAvailabilityListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchAvailablityBox = new System.Windows.Forms.ComboBox();
            this.buyMedBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicine Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medicine Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicine Name:";
            // 
            // stockMedNameTextBox
            // 
            this.stockMedNameTextBox.Location = new System.Drawing.Point(122, 49);
            this.stockMedNameTextBox.Name = "stockMedNameTextBox";
            this.stockMedNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockMedNameTextBox.TabIndex = 6;
            // 
            // stockMedQtyTextBox
            // 
            this.stockMedQtyTextBox.Location = new System.Drawing.Point(122, 78);
            this.stockMedQtyTextBox.Name = "stockMedQtyTextBox";
            this.stockMedQtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockMedQtyTextBox.TabIndex = 7;
            // 
            // stockMedUnitPriceTextBox
            // 
            this.stockMedUnitPriceTextBox.Location = new System.Drawing.Point(122, 110);
            this.stockMedUnitPriceTextBox.Name = "stockMedUnitPriceTextBox";
            this.stockMedUnitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockMedUnitPriceTextBox.TabIndex = 8;
            // 
            // stockMedButton
            // 
            this.stockMedButton.Location = new System.Drawing.Point(268, 76);
            this.stockMedButton.Name = "stockMedButton";
            this.stockMedButton.Size = new System.Drawing.Size(75, 35);
            this.stockMedButton.TabIndex = 9;
            this.stockMedButton.Text = "Stock Medicine";
            this.stockMedButton.UseVisualStyleBackColor = true;
            this.stockMedButton.Click += new System.EventHandler(this.stockMedButton_Click);
            // 
            // buyMedQtyTextBox
            // 
            this.buyMedQtyTextBox.Location = new System.Drawing.Point(539, 78);
            this.buyMedQtyTextBox.Name = "buyMedQtyTextBox";
            this.buyMedQtyTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyMedQtyTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Medicine Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Medicine Amount:";
            // 
            // buyMedButton
            // 
            this.buyMedButton.Location = new System.Drawing.Point(672, 71);
            this.buyMedButton.Name = "buyMedButton";
            this.buyMedButton.Size = new System.Drawing.Size(75, 23);
            this.buyMedButton.TabIndex = 14;
            this.buyMedButton.Text = "Buy";
            this.buyMedButton.UseVisualStyleBackColor = true;
            this.buyMedButton.Click += new System.EventHandler(this.buyMedButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Medicine Name:";
            // 
            // medAvailabilityButton
            // 
            this.medAvailabilityButton.Location = new System.Drawing.Point(282, 199);
            this.medAvailabilityButton.Name = "medAvailabilityButton";
            this.medAvailabilityButton.Size = new System.Drawing.Size(75, 39);
            this.medAvailabilityButton.TabIndex = 17;
            this.medAvailabilityButton.Text = "Show Availability";
            this.medAvailabilityButton.UseVisualStyleBackColor = true;
            this.medAvailabilityButton.Click += new System.EventHandler(this.medAvailabilityButton_Click);
            // 
            // medAvailabilityListBox
            // 
            this.medAvailabilityListBox.FormattingEnabled = true;
            this.medAvailabilityListBox.Location = new System.Drawing.Point(12, 244);
            this.medAvailabilityListBox.Name = "medAvailabilityListBox";
            this.medAvailabilityListBox.Size = new System.Drawing.Size(415, 134);
            this.medAvailabilityListBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Total Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchAvailablityBox
            // 
            this.searchAvailablityBox.FormattingEnabled = true;
            this.searchAvailablityBox.Location = new System.Drawing.Point(122, 209);
            this.searchAvailablityBox.Name = "searchAvailablityBox";
            this.searchAvailablityBox.Size = new System.Drawing.Size(121, 21);
            this.searchAvailablityBox.TabIndex = 21;
            // 
            // buyMedBox
            // 
            this.buyMedBox.FormattingEnabled = true;
            this.buyMedBox.Location = new System.Drawing.Point(539, 48);
            this.buyMedBox.Name = "buyMedBox";
            this.buyMedBox.Size = new System.Drawing.Size(121, 21);
            this.buyMedBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buyMedBox);
            this.Controls.Add(this.searchAvailablityBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.medAvailabilityListBox);
            this.Controls.Add(this.medAvailabilityButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buyMedButton);
            this.Controls.Add(this.buyMedQtyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stockMedButton);
            this.Controls.Add(this.stockMedUnitPriceTextBox);
            this.Controls.Add(this.stockMedQtyTextBox);
            this.Controls.Add(this.stockMedNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mayer Dowa Owshodh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockMedNameTextBox;
        private System.Windows.Forms.TextBox stockMedQtyTextBox;
        private System.Windows.Forms.TextBox stockMedUnitPriceTextBox;
        private System.Windows.Forms.Button stockMedButton;
        private System.Windows.Forms.TextBox buyMedQtyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buyMedButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button medAvailabilityButton;
        private System.Windows.Forms.ListBox medAvailabilityListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox searchAvailablityBox;
        private System.Windows.Forms.ComboBox buyMedBox;
    }
}

