using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "Start Game":
                    Form1 a = new Form1();
                    a.Show();
                    this.Hide();
                    break;
                case "Exit Game":
                    Application.Exit();
                    break;
                default:
                    break;

            }
        }
    }
}
