namespace banking_system
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
            this.label2 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Id_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.create_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.amount_deposite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.amoutn_withdraw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.check_balance_listBox = new System.Windows.Forms.ListBox();
            this.amounttxt = new System.Windows.Forms.TextBox();
            this.amount_txt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.check_history_listbox = new System.Windows.Forms.ListBox();
            this.idBoxAccInf = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.id_check_history = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deposit_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.withdraw_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(84, 118);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 3;
            // 
            // Id_txt
            // 
            this.Id_txt.Location = new System.Drawing.Point(84, 152);
            this.Id_txt.Name = "Id_txt";
            this.Id_txt.Size = new System.Drawing.Size(100, 20);
            this.Id_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            // 
            // create_combo
            // 
            this.create_combo.FormattingEnabled = true;
            this.create_combo.Items.AddRange(new object[] {
            "Current",
            "Savings",
            "Loan"});
            this.create_combo.Location = new System.Drawing.Point(84, 82);
            this.create_combo.Name = "create_combo";
            this.create_combo.Size = new System.Drawing.Size(121, 21);
            this.create_combo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "TYPE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(263, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = "DEPOSIT:";
            // 
            // amount_deposite
            // 
            this.amount_deposite.Location = new System.Drawing.Point(318, 115);
            this.amount_deposite.Name = "amount_deposite";
            this.amount_deposite.Size = new System.Drawing.Size(100, 20);
            this.amount_deposite.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Amount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "CREATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateOnClik);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "DEPOSITE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deposit_on_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "WITHDRAW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.withdraw_on_click);
            // 
            // amoutn_withdraw
            // 
            this.amoutn_withdraw.Location = new System.Drawing.Point(558, 115);
            this.amoutn_withdraw.Name = "amoutn_withdraw";
            this.amoutn_withdraw.Size = new System.Drawing.Size(100, 20);
            this.amoutn_withdraw.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Amount:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(503, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 31);
            this.label14.TabIndex = 27;
            this.label14.Text = "WITHDRAW:";
            // 
            // check_balance_listBox
            // 
            this.check_balance_listBox.FormattingEnabled = true;
            this.check_balance_listBox.Location = new System.Drawing.Point(35, 368);
            this.check_balance_listBox.Name = "check_balance_listBox";
            this.check_balance_listBox.Size = new System.Drawing.Size(309, 95);
            this.check_balance_listBox.TabIndex = 37;
            // 
            // amounttxt
            // 
            this.amounttxt.Location = new System.Drawing.Point(84, 185);
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.Size = new System.Drawing.Size(100, 20);
            this.amounttxt.TabIndex = 39;
            // 
            // amount_txt
            // 
            this.amount_txt.AutoSize = true;
            this.amount_txt.Location = new System.Drawing.Point(32, 188);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(46, 13);
            this.amount_txt.TabIndex = 38;
            this.amount_txt.Text = "Amount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(335, 31);
            this.label12.TabIndex = 43;
            this.label12.Text = "CHECK ACC BALANCE:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(412, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(261, 31);
            this.label13.TabIndex = 44;
            this.label13.Text = "CHECK HISTORY:";
            // 
            // check_history_listbox
            // 
            this.check_history_listbox.FormattingEnabled = true;
            this.check_history_listbox.Location = new System.Drawing.Point(418, 368);
            this.check_history_listbox.Name = "check_history_listbox";
            this.check_history_listbox.Size = new System.Drawing.Size(300, 95);
            this.check_history_listbox.TabIndex = 45;
            this.check_history_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // idBoxAccInf
            // 
            this.idBoxAccInf.Location = new System.Drawing.Point(128, 329);
            this.idBoxAccInf.Margin = new System.Windows.Forms.Padding(2);
            this.idBoxAccInf.Name = "idBoxAccInf";
            this.idBoxAccInf.Size = new System.Drawing.Size(120, 20);
            this.idBoxAccInf.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(68, 329);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "ID :";
            // 
            // id_check_history
            // 
            this.id_check_history.Location = new System.Drawing.Point(475, 320);
            this.id_check_history.Margin = new System.Windows.Forms.Padding(2);
            this.id_check_history.Name = "id_check_history";
            this.id_check_history.Size = new System.Drawing.Size(120, 20);
            this.id_check_history.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(415, 320);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "ID :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "CHECK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Check_balance_on_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(535, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 51;
            this.button5.Text = "CHECK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.checkHistoryOnclick);
            // 
            // deposit_txt
            // 
            this.deposit_txt.Location = new System.Drawing.Point(318, 87);
            this.deposit_txt.Name = "deposit_txt";
            this.deposit_txt.Size = new System.Drawing.Size(100, 20);
            this.deposit_txt.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "ID:";
            // 
            // withdraw_txt
            // 
            this.withdraw_txt.Location = new System.Drawing.Point(558, 82);
            this.withdraw_txt.Name = "withdraw_txt";
            this.withdraw_txt.Size = new System.Drawing.Size(100, 20);
            this.withdraw_txt.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 516);
            this.Controls.Add(this.withdraw_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deposit_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.id_check_history);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.idBoxAccInf);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.check_history_listbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.amounttxt);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.check_balance_listBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.amoutn_withdraw);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amount_deposite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.create_combo);
            this.Controls.Add(this.Id_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox Id_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox create_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amount_deposite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox amoutn_withdraw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox check_balance_listBox;
        private System.Windows.Forms.TextBox amounttxt;
        private System.Windows.Forms.Label amount_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox check_history_listbox;
        private System.Windows.Forms.TextBox idBoxAccInf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox id_check_history;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox deposit_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdraw_txt;
        private System.Windows.Forms.Label label5;
    }
}

