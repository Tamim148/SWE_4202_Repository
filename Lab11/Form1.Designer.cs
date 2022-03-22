namespace Lab11TicTacToe
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.ComputerScoreLabel = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.PlayerVsComputerButton = new System.Windows.Forms.RadioButton();
            this.PlayerVsDefensiveAiButton = new System.Windows.Forms.RadioButton();
            this.PlayerMarkerComboBox = new System.Windows.Forms.ComboBox();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.ComputerMovesFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Score :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Computer Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player\'s Marker";
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Location = new System.Drawing.Point(147, 108);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.PlayerScoreLabel.TabIndex = 4;
            this.PlayerScoreLabel.Text = "0";
            // 
            // ComputerScoreLabel
            // 
            this.ComputerScoreLabel.AutoSize = true;
            this.ComputerScoreLabel.Location = new System.Drawing.Point(148, 140);
            this.ComputerScoreLabel.Name = "ComputerScoreLabel";
            this.ComputerScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.ComputerScoreLabel.TabIndex = 5;
            this.ComputerScoreLabel.Text = "0";
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(250, 130);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 71);
            this.A1.TabIndex = 6;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // PlayerVsComputerButton
            // 
            this.PlayerVsComputerButton.AutoSize = true;
            this.PlayerVsComputerButton.Location = new System.Drawing.Point(650, 64);
            this.PlayerVsComputerButton.Name = "PlayerVsComputerButton";
            this.PlayerVsComputerButton.Size = new System.Drawing.Size(117, 17);
            this.PlayerVsComputerButton.TabIndex = 7;
            this.PlayerVsComputerButton.TabStop = true;
            this.PlayerVsComputerButton.Text = "Player Vs Computer";
            this.PlayerVsComputerButton.UseVisualStyleBackColor = true;
            // 
            // PlayerVsDefensiveAiButton
            // 
            this.PlayerVsDefensiveAiButton.AutoSize = true;
            this.PlayerVsDefensiveAiButton.Location = new System.Drawing.Point(650, 104);
            this.PlayerVsDefensiveAiButton.Name = "PlayerVsDefensiveAiButton";
            this.PlayerVsDefensiveAiButton.Size = new System.Drawing.Size(133, 17);
            this.PlayerVsDefensiveAiButton.TabIndex = 8;
            this.PlayerVsDefensiveAiButton.TabStop = true;
            this.PlayerVsDefensiveAiButton.Text = "Player Vs Defensive AI";
            this.PlayerVsDefensiveAiButton.UseVisualStyleBackColor = true;
            // 
            // PlayerMarkerComboBox
            // 
            this.PlayerMarkerComboBox.FormattingEnabled = true;
            this.PlayerMarkerComboBox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.PlayerMarkerComboBox.Location = new System.Drawing.Point(731, 144);
            this.PlayerMarkerComboBox.Name = "PlayerMarkerComboBox";
            this.PlayerMarkerComboBox.Size = new System.Drawing.Size(44, 21);
            this.PlayerMarkerComboBox.TabIndex = 9;
            this.PlayerMarkerComboBox.SelectedIndexChanged += new System.EventHandler(this.label2_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(331, 130);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 71);
            this.A2.TabIndex = 10;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(412, 130);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 71);
            this.A3.TabIndex = 11;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(250, 207);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 71);
            this.B1.TabIndex = 12;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(331, 207);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 71);
            this.B2.TabIndex = 13;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(412, 207);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 71);
            this.B3.TabIndex = 14;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(250, 284);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 71);
            this.C1.TabIndex = 15;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(331, 284);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 71);
            this.C2.TabIndex = 16;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(412, 284);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 71);
            this.C3.TabIndex = 17;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // ComputerMovesFirst
            // 
            this.ComputerMovesFirst.Location = new System.Drawing.Point(649, 174);
            this.ComputerMovesFirst.Name = "ComputerMovesFirst";
            this.ComputerMovesFirst.Size = new System.Drawing.Size(75, 50);
            this.ComputerMovesFirst.TabIndex = 18;
            this.ComputerMovesFirst.Text = "Computer Moves First";
            this.ComputerMovesFirst.UseVisualStyleBackColor = true;
            this.ComputerMovesFirst.Click += new System.EventHandler(this.ComputerMovesFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComputerMovesFirst);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.PlayerMarkerComboBox);
            this.Controls.Add(this.PlayerVsDefensiveAiButton);
            this.Controls.Add(this.PlayerVsComputerButton);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.ComputerScoreLabel);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Label ComputerScoreLabel;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.RadioButton PlayerVsComputerButton;
        private System.Windows.Forms.RadioButton PlayerVsDefensiveAiButton;
        private System.Windows.Forms.ComboBox PlayerMarkerComboBox;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button ComputerMovesFirst;
    }
}

