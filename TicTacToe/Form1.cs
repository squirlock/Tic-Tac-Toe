using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool turn = true; //true is X turn and false is O turn
        int turn_count = 0;
        String aboutDeveloper = "Hi! I am Ankit Mathur and I am currently a C# Developer. I have more than 2 years of experience in C# and Azure Development. Please reach out to me at ankit301095@gmail.com.";
        String aboutApp = "This is a basic Tic-Tac-Toe Game developed via Windows Form Application.";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false;
            turn_count++;

            check_for_winner();
        }

        private void check_for_winner()
        {
            bool winnerCheck = false;
            
            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winnerCheck = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winnerCheck = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winnerCheck = true;

            //vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winnerCheck = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winnerCheck = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winnerCheck = true;

            //diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winnerCheck = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winnerCheck = true;

            if (winnerCheck)
            {
                disableAllButtons();
                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + " Wins! Congratulations!!! \n\nSelect New Game (File -> New Game) to play a new game.\n\nSelect Exit (File -> Exit) to quit the game.", "Congrats!");
            }
            else 
            {
                if (turn_count == 9)
                    MessageBox.Show("Good Game, but it's a Draw. Try Again! \n\nSelect New Game (File -> New Game) to play a new game.\n\nSelect Exit (File -> Exit) to quit the game.", "Good Game!");
            }
        }

        private void disableAllButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
            catch { }
        }

        private void contextFileStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String contextFileOption = e.ClickedItem.Text;
            switch (contextFileOption)
            {
                case "New Game":
                    turn = true;
                    turn_count = 0;
                    try
                    {
                        foreach (Control c in Controls)
                        {
                            Button button = (Button)c;
                            button.Enabled = true;
                            button.Text = "";
                        }
                    }
                    catch { }
                    break;
                case "Exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void contextHelpStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String contextHelpOption = e.ClickedItem.Text;
            switch (contextHelpOption)
            {
                case "About App":
                    MessageBox.Show(aboutApp, "About Calculator");
                    break;
                case "About Developer":
                    MessageBox.Show(aboutDeveloper, "About the Developer");
                    break;
                default:
                    break;

            }
        }
    }
}
