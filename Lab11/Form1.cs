using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        int counter = 0;
        int PlayerWinCount = 0;
        int ComputerWinCount = 0;

        private void button_click(object sender, EventArgs e)
        {
            if(PlayerVsComputerButton.Checked==false && PlayerVsDefensiveAiButton.Checked==false)
            {
                MessageBox.Show("Select a Difficulty!");
                return;
            }
            if(PlayerMarkerComboBox.Text =="")
            {
                MessageBox.Show("Select a Marker!");
                return;
            }
            string PlayerMarker = PlayerMarkerComboBox.Text;
            string ComputerMarker;
//            bool turn = true;
            if (PlayerMarker == "X")
            {
                ComputerMarker = "O";
            }
            else
                ComputerMarker = "X";
//            if (turn)
//            {
                Button b = (Button)sender;

                b.Text = PlayerMarker;
                counter = counter + 1;
                b.Enabled = false;
//                turn = !turn;
//            }

            if (CheckVictory(PlayerMarker, ComputerMarker) == true)
            {
                return;
            }

            //            if (!turn)
            //            {
            if (PlayerVsDefensiveAiButton.Checked == true)
            {
                DefensiveAIMove(PlayerMarker, ComputerMarker);
                counter++;
            }
            else
            { 
                ComputerMove(PlayerMarker, ComputerMarker);
                counter++;
            }
  
//                turn = !turn;
                CheckVictory(PlayerMarker, ComputerMarker);
//            }
        }
        private void ComputerMove(string PlayerMarker, string ComputerMarker)
        {
            Random rnd = new Random();
            bool CompMove=false;
            while(CompMove!=true)
            {
                int randomNumber = rnd.Next(1,9);
                if(randomNumber == 1)
                {
                    if(A1.Enabled == true)
                    {
                        A1.Text = ComputerMarker;
                        A1.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 2)
                {
                    if (A2.Enabled == true)
                    {
                        A2.Text = ComputerMarker;
                        A2.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 3)
                {
                    if (A3.Enabled == true)
                    {
                        A3.Text = ComputerMarker;
                        A3.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 4)
                {
                    if (B1.Enabled == true)
                    {
                        B1.Text = ComputerMarker;
                        B1.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 5)
                {
                    if (B2.Enabled == true)
                    {
                        B2.Text = ComputerMarker;
                        B2.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 6)
                {
                    if (B3.Enabled == true)
                    {
                        B3.Text = ComputerMarker;
                        B3.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 7)
                {
                    if (C1.Enabled == true)
                    {
                        C1.Text = ComputerMarker;
                        C1.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 8)
                {
                    if (C2.Enabled == true)
                    {
                        C2.Text = ComputerMarker;
                        C2.Enabled = false;
                        CompMove = true;
                    }
                }
                if (randomNumber == 9)
                {
                    if (C3.Enabled == true)
                    {
                        C3.Text = ComputerMarker;
                        C3.Enabled = false;
                        CompMove = true;
                    }
                }
            }

        }
        private void DefensiveAIMove(string PlayerMarker, string ComputerMarker)
        {
            if (B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && A1.Enabled == true && A3.Enabled == true && C1.Enabled == true && C3.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && A1.Text == PlayerMarker && A3.Enabled == true && C1.Enabled == true && C3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            } //random
            else if (A1.Text == PlayerMarker && C3.Text == PlayerMarker && A2.Enabled == true)
            {
                if (C1.Text == PlayerMarker && C3.Text == PlayerMarker && C2.Enabled == true)
                {
                    C2.Text = ComputerMarker;
                    C2.Enabled = false;
                }
                else if(A1.Text == PlayerMarker && A3.Text == PlayerMarker)
                {
                    A2.Text = ComputerMarker;
                    A2.Enabled =false;
                }
                else
                {
                    A2.Text= ComputerMarker;
                    A2.Enabled =false;
                }
            }
            else if (A3.Text == PlayerMarker && C1.Text == PlayerMarker && A2.Enabled == true)
            {
                if (C1.Text == PlayerMarker && C3.Text == PlayerMarker && C2.Enabled == true)
                {
                    C2.Text = ComputerMarker;
                    C2.Enabled = false;
                }
                else if (A1.Text == PlayerMarker && A3.Text == PlayerMarker)
                {
                    A2.Text = ComputerMarker;
                    A2.Enabled = false;
                }
                else
                {
                    A2.Text = ComputerMarker;
                    A2.Enabled = false;
                }
            }
            else if (A1.Text == ComputerMarker && A2.Text == ComputerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }
            else if (A2.Text == ComputerMarker && A3.Text == ComputerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A1.Text == ComputerMarker && A3.Text == ComputerMarker && A2.Enabled == true)
            {
                A2.Text = ComputerMarker;
                A2.Enabled = false;
            }
            else if (B1.Text == ComputerMarker && B2.Text == ComputerMarker && B3.Enabled == true)
            {
                B3.Text = ComputerMarker;
                B3.Enabled = false;
            }
            else if (B2.Text == ComputerMarker && B3.Text == ComputerMarker && B1.Enabled == true)
            {
                B1.Text = ComputerMarker;
                B1.Enabled = false;
            }
            else if (B1.Text == ComputerMarker && B3.Text == ComputerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (C1.Text == ComputerMarker && C2.Text == ComputerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (C2.Text == ComputerMarker && C3.Text == ComputerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (C1.Text == ComputerMarker && C3.Text == ComputerMarker && C2.Enabled == true)
            {
                C2.Text = ComputerMarker;
                C2.Enabled = false;
            }//horizontal losing check
            else if (A1.Text == ComputerMarker && B1.Text == ComputerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (A1.Text == ComputerMarker && C1.Text == ComputerMarker && B1.Enabled == true)
            {
                B1.Text = ComputerMarker;
                B1.Enabled = false;
            }
            else if (B1.Text == ComputerMarker && C1.Text == ComputerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A2.Text == ComputerMarker && B2.Text == ComputerMarker && C2.Enabled == true)
            {
                C2.Text = ComputerMarker;
                C2.Enabled = false;
            }
            else if (A2.Text == ComputerMarker && C2.Text == ComputerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == ComputerMarker && C2.Text == ComputerMarker && A2.Enabled == true)
            {
                A2.Text = ComputerMarker;
                A2.Enabled = false;
            }
            else if (A3.Text == ComputerMarker && B3.Text == ComputerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (A3.Text == ComputerMarker && C3.Text == ComputerMarker && B3.Enabled == true)
            {
                B3.Text = ComputerMarker;
                B3.Enabled = false;
            }
            else if (B3.Text == ComputerMarker && C3.Text == ComputerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }//vertical loss check
            else if (A1.Text == ComputerMarker && B2.Text == ComputerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (A1.Text == ComputerMarker && C3.Text == ComputerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == ComputerMarker && C3.Text == ComputerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A3.Text == ComputerMarker && B2.Text == ComputerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (A3.Text == ComputerMarker && C1.Text == ComputerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == ComputerMarker && C1.Text == ComputerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }//diagonal loss check
            else if (A1.Text == PlayerMarker && A2.Enabled == true && C3.Text == PlayerMarker)
            {
                A2.Text = ComputerMarker;
                A2.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && C1.Text == PlayerMarker && C2.Enabled == true)
            {
                C2.Text = ComputerMarker;
                C2.Enabled = false;
            }
            else if (A1.Text == PlayerMarker && A2.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }
            else if (A2.Text == PlayerMarker && A3.Text == PlayerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A1.Text == PlayerMarker && A3.Text == PlayerMarker && A2.Enabled == true)
            {
                A2.Text = ComputerMarker;
                A2.Enabled = false;
            }
            else if (B1.Text == PlayerMarker && B2.Text == PlayerMarker && B3.Enabled == true)
            {
                B3.Text = ComputerMarker;
                B3.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && B3.Text == PlayerMarker && B1.Enabled == true)
            {
                B1.Text = ComputerMarker;
                B1.Enabled = false;
            }
            else if (B1.Text == PlayerMarker && B3.Text == PlayerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (C1.Text == PlayerMarker && C2.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (C2.Text == PlayerMarker && C3.Text == PlayerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (C1.Text == PlayerMarker && C3.Text == PlayerMarker && C2.Enabled == true)
            {
                C2.Text = ComputerMarker;
                C2.Enabled = false;
            }//horizontal losing check
            else if (A1.Text == PlayerMarker && B1.Text == PlayerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (A1.Text == PlayerMarker && C1.Text == PlayerMarker && B1.Enabled == true)
            {
                B1.Text = ComputerMarker;
                B1.Enabled = false;
            }
            else if (B1.Text == PlayerMarker && C1.Text == PlayerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A2.Text == PlayerMarker && B2.Text == PlayerMarker && C2.Enabled == true)
            {
                C2.Text = ComputerMarker;
                C2.Enabled = false;
            }
            else if (A2.Text == PlayerMarker && C2.Text == PlayerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && C2.Text == PlayerMarker && A2.Enabled == true)
            {
                A2.Text = ComputerMarker;
                A2.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && B3.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && C3.Text == PlayerMarker && B3.Enabled == true)
            {
                B3.Text = ComputerMarker;
                B3.Enabled = false;
            }
            else if (B3.Text == PlayerMarker && C3.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }//vertical loss check
            else if (A1.Text == PlayerMarker && B2.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (A1.Text == PlayerMarker && C3.Text == PlayerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && C3.Text == PlayerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && B2.Text == PlayerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && C1.Text == PlayerMarker && B2.Enabled == true)
            {
                B2.Text = ComputerMarker;
                B2.Enabled = false;
            }
            else if (B2.Text == PlayerMarker && C1.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }//diagonal loss check
            else if (A2.Text == PlayerMarker && B1.Text == PlayerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (B1.Text == PlayerMarker && C2.Text == PlayerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (C2.Text == PlayerMarker && B3.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (B3.Text == PlayerMarker && A2.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }//Median loss check
            else if (A1.Text == PlayerMarker && B3.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text = ComputerMarker;
                A3.Enabled = false;
            }
            else if (A1.Text == PlayerMarker && C2.Text == PlayerMarker && C1.Enabled == true)
            {
                C1.Text = ComputerMarker;
                C1.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && C2.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text = ComputerMarker;
                C3.Enabled = false;
            }
            else if (A3.Text == PlayerMarker && B1.Text == PlayerMarker && A1.Enabled == true)
            {
                A1.Text = ComputerMarker;
                A1.Enabled = false;
            }
            else if (C3.Text == PlayerMarker && A2.Text == PlayerMarker && A3.Enabled == true)
            {
                A3.Text= ComputerMarker;
                A3.Enabled= false;
            }
            else if (C3.Text == PlayerMarker && B1.Text== PlayerMarker && C1.Enabled == true)
            {
                C1.Text= ComputerMarker;
                C1.Enabled= false;
            }
            else if (C1.Text == PlayerMarker && A2.Text== PlayerMarker && A1.Enabled == true)
            {
                A1.Text= ComputerMarker;
                A1.Enabled = false;
            }
            else if (C1.Text == PlayerMarker && B3.Text == PlayerMarker && C3.Enabled == true)
            {
                C3.Text= ComputerMarker;
                C3.Enabled= false;
            }
            else ComputerMove(PlayerMarker, ComputerMarker);
        }
        private bool CheckVictory(string PlayerMarker, string ComputerMarker)
        {
            bool PlayerWin = false;
            bool ComputerWin = false;
            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text !="")
            {
                if (A1.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text!="")
            {
                if (B1.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text!="")
            {
                if (C1.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text!="")
            {
                if (A1.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text!="")
            {
                if (A2.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text!="")
            {
                if (A3.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if(A1.Text == B2.Text && B2.Text == C3.Text && A1.Text!="")
            {
                if (A1.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            else if(A3.Text == B2.Text && B2.Text == C1.Text && A3.Text!="")
            {
                if (A3.Text == PlayerMarker)
                {
                    PlayerWin = true;
                }
                else
                    ComputerWin = true;
            }
            if(PlayerWin == true)
            {
                PlayerWinCount++;
                PlayerScoreLabel.Text = PlayerWinCount.ToString();
                MessageBox.Show("Player Won!");
            }
            else if(ComputerWin == true)
            {
                ComputerWinCount++;
                ComputerScoreLabel.Text = ComputerWinCount.ToString();
                MessageBox.Show("Computer Won!");
            }
            else if(counter == 9 && PlayerWin == false && ComputerWin == false)
            {
                MessageBox.Show("It's a Tie!");
            }
            if (PlayerWin == true || ComputerWin == true || counter == 9)
            {
                A1.Text = "";
                A2.Text = "";
                A3.Text = "";
                B1.Text = "";
                B2.Text = "";
                B3.Text = "";
                C1.Text = "";
                C2.Text = "";
                C3.Text = "";
                A1.Enabled = true;
                A2.Enabled = true;
                A3.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                C1.Enabled = true;
                C2.Enabled = true;
                C3.Enabled = true;
                counter = 0;
                return true;
            }
            else 
                return false;
        }

        private void ComputerMovesFirst_Click(object sender, EventArgs e)
        {
            if (PlayerMarkerComboBox.Text == "")
            {
                MessageBox.Show("Select a Marker!");
                return;
            }
            if(PlayerVsDefensiveAiButton.Checked == false && PlayerVsComputerButton.Checked == false)
            {
                MessageBox.Show("Select a Difficulty!");
                return;
            }
            if(counter !=0)
            {
                MessageBox.Show("Invalid Move!");
                return;
            }
            string PlayerMarker = PlayerMarkerComboBox.Text;
            string ComputerMarker;
            if (PlayerMarker == "X")
            {
                ComputerMarker = "O";
            }
            else ComputerMarker = "X";
            
            if(PlayerVsComputerButton.Checked == true)
            {
                ComputerMove(PlayerMarker, ComputerMarker);
            }
            else if(PlayerVsDefensiveAiButton.Checked == true)
            {
                if (A1.Enabled == true && A3.Enabled == true && C1.Enabled == true && C3.Enabled == true)
                {
                    Random rnd = new Random();
                    int randomNumber = rnd.Next(1, 4);
                    if (randomNumber == 1)
                    {
                        A1.Text = ComputerMarker;
                        A1.Enabled = false;
                    }
                    else if (randomNumber == 2)
                    {
                        A3.Text = ComputerMarker;
                        A3.Enabled = false;
                    }
                    else if (randomNumber == 3)
                    {
                        C1.Text = ComputerMarker;
                        C1.Enabled = false;
                    }
                    else if (randomNumber == 4)
                    {
                        C3.Text = ComputerMarker;
                        C3.Enabled = false;
                    }
                }
            }
            counter++;
        }
    }
}
