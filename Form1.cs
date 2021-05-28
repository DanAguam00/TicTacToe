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
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {

            Btn0.Text = "X";
            Btn0.BackColor = Color.MistyRose;
            Btn0.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            Btn1.Text = "X";
            Btn1.BackColor = Color.MistyRose;
            Btn1.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Btn2.Text = "X";
            Btn2.BackColor = Color.MistyRose;
            Btn2.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Btn3.Text = "X";
            Btn3.BackColor = Color.MistyRose;
            Btn3.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Btn4.Text = "X";
            Btn4.BackColor = Color.MistyRose;
            Btn4.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Btn5.Text = "X";
            Btn5.BackColor = Color.MistyRose;
            Btn5.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Btn6.Text = "X";
            Btn6.BackColor = Color.MistyRose;
            Btn6.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Btn7.Text = "X";
            Btn7.BackColor = Color.MistyRose;
            Btn7.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Btn8.Text = "X";
            Btn8.BackColor = Color.MistyRose;
            Btn8.Enabled = false;
            Winner();
            computerGuess();
        }

        private void Winner()
        {
            bool win = false;
            bool player = false;
            if ((Btn0.Text == "X") && (Btn0.Text == Btn1.Text) && (Btn1.Text == Btn2.Text) && (Btn0.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn3.Text == "X") && (Btn3.Text == Btn4.Text) && (Btn4.Text == Btn5.Text) && (Btn3.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn6.Text == "X") && (Btn6.Text == Btn7.Text) && (Btn7.Text == Btn8.Text) && (Btn6.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn0.Text == "X") && (Btn0.Text == Btn3.Text) && (Btn3.Text == Btn6.Text) && (Btn0.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn1.Text == "X") && (Btn1.Text == Btn4.Text) && (Btn4.Text == Btn7.Text) && (Btn1.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn2.Text == "X") && (Btn2.Text == Btn5.Text) && (Btn5.Text == Btn8.Text) && (Btn2.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn0.Text == "X") && (Btn0.Text == Btn4.Text) && (Btn4.Text == Btn8.Text) && (Btn0.Enabled == false))
            {
                win = true;
                player = true;
            }
            else if ((Btn2.Text == "X") && (Btn2.Text == Btn4.Text) && (Btn4.Text == Btn6.Text) && (Btn2.Enabled == false))
            {
                win = true;
                player = true;
            }
            else
            {
                win = false;
            }

            //Message
            if (win == true)
            {
                if (player == true)
                {
                    MessageBox.Show("X is the winner", "Winner");
                }
                else
                {
                    MessageBox.Show("O is the winner ", "Winner");

                }
            }
        }
        private void computerGuess()
        {
            Random generator = new();
            byte number = (byte)generator.Next(0, 8);

            
            if (number == 0)
            {
                if (Btn0.Enabled == true)
                {
                    Btn0.Text = "O";
                    Btn0.BackColor = Color.LightCyan;
                    Btn0.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 1) 
            {
                if (Btn1.Enabled == true)
                {
                    Btn1.Text = "O";
                    Btn1.BackColor = Color.LightCyan;
                    Btn1.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 2)
            {
                if (Btn2.Enabled == true)
                {
                    Btn2.Text = "O";
                    Btn2.BackColor = Color.LightCyan;
                    Btn2.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 3) 
            {
                if (Btn0.Enabled == true)
                {
                    Btn0.Text = "O";
                    Btn0.BackColor = Color.LightCyan;
                    Btn0.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 4)
            {
                if (Btn4.Enabled == true)
                {
                    Btn4.Text = "O";
                    Btn4.BackColor = Color.LightCyan;
                    Btn4.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 5) 
            {
                if (Btn5.Enabled == true)
                {
                    Btn5.Text = "O";
                    Btn5.BackColor = Color.LightCyan;
                    Btn5.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 6)
            {
                if (Btn6.Enabled == true)
                {
                    Btn6.Text = "O";
                    Btn6.BackColor = Color.LightCyan;
                    Btn6.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 7)
            {
                if (Btn7.Enabled == true)
                {
                    Btn7.Text = "O";
                    Btn7.BackColor = Color.LightCyan;
                    Btn7.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }

            else if (number == 8)
            {
                if (Btn8.Enabled == true)
                {
                    Btn8.Text = "O";
                    Btn8.BackColor = Color.LightCyan;
                    Btn8.Enabled = false;
                    Winner();
                }
                else
                {
                    byte number1 = (byte)generator.Next(0, 8);
                    number = number1;
                }
            }
        }
    }
}
