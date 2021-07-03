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
        byte turns = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            Btn.Text = "X";
            Btn.BackColor = Color.MistyRose;
            Btn.Enabled = false;
            Winner();
            computerGuess();
        }
        private void computerGuess()
        {
            while (true)
            {
                Random generator = new();
                byte number = (byte)generator.Next(0, 8);
                byte drawCountdown = 0;
                               

                if (number == 0)
                {
                    if (Btn0.Enabled == true)
                    {
                        Btn0.Text = "O";
                        Btn0.BackColor = Color.LightCyan;
                        Btn0.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 1)
                {
                    if (Btn1.Enabled == true)
                    {
                        Btn1.Text = "O";
                        Btn1.BackColor = Color.LightCyan;
                        Btn1.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 2)
                {
                    if (Btn2.Enabled == true)
                    {
                        Btn2.Text = "O";
                        Btn2.BackColor = Color.LightCyan;
                        Btn2.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 3)
                {
                    if (Btn3.Enabled == true)
                    {
                        Btn3.Text = "O";
                        Btn3.BackColor = Color.LightCyan;
                        Btn3.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 4)
                {
                    if (Btn4.Enabled == true)
                    {
                        Btn4.Text = "O";
                        Btn4.BackColor = Color.LightCyan;
                        Btn4.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 5)
                {
                    if (Btn5.Enabled == true)
                    {
                        Btn5.Text = "O";
                        Btn5.BackColor = Color.LightCyan;
                        Btn5.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 6)
                {
                    if (Btn6.Enabled == true)
                    {
                        Btn6.Text = "O";
                        Btn6.BackColor = Color.LightCyan;
                        Btn6.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
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
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (number == 8)
                {
                    if (Btn8.Enabled == true)
                    {
                        Btn8.Text = "O";
                        Btn8.BackColor = Color.LightCyan;
                        Btn8.Enabled = false;
                        drawCountdown++;
                        Winner();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (drawCountdown == 8)
                {
                    Winner();
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        private void disableAllButtons()
        {
            if(Btn0.Enabled == true)
            {
                Btn0.Enabled = false;
            }

            if (Btn1.Enabled == true)
            {
                Btn1.Enabled = false;
            }

            if (Btn2.Enabled == true)
            {
                Btn2.Enabled = false;
            }

            if (Btn3.Enabled == true)
            {
                Btn3.Enabled = false;
            }

            if (Btn4.Enabled == true)
            {
                Btn4.Enabled = false;
            }

            if (Btn5.Enabled == true)
            {
                Btn5.Enabled = false;
            }

            if (Btn6.Enabled == true)
            {
                Btn6.Enabled = false;
            }

            if (Btn7.Enabled == true)
            {
                Btn7.Enabled = false;
            }

            if (Btn8.Enabled == true)
            {
                Btn8.Enabled = false;
            }
        }
        private void Winner()
        {
            bool win = false;
            bool player = false;
            if ((Btn0.Text == Btn1.Text) && (Btn1.Text == Btn2.Text) && (Btn0.Enabled == false))
            {
                win = true;
                if (Btn0.Text == "X")
                {
                    player = true;
                }
                else if (Btn0.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn3.Text == Btn4.Text) && (Btn4.Text == Btn5.Text) && (Btn3.Enabled == false))
            {
                win = true;
                if (Btn3.Text == "X")
                {
                    player = true;
                }
                else if (Btn3.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn6.Text == Btn7.Text) && (Btn7.Text == Btn8.Text) && (Btn6.Enabled == false))
            {
                win = true;
                if (Btn6.Text == "X")
                {
                    player = true;
                }
                else if (Btn6.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn0.Text == Btn3.Text) && (Btn3.Text == Btn6.Text) && (Btn0.Enabled == false))
            {
                win = true;
                if (Btn0.Text == "X")
                {
                    player = true;
                }
                else if (Btn0.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn1.Text == Btn4.Text) && (Btn4.Text == Btn7.Text) && (Btn1.Enabled == false))
            {
                win = true;
                if (Btn1.Text == "X")
                {
                    player = true;
                }
                else if (Btn1.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn2.Text == Btn5.Text) && (Btn5.Text == Btn8.Text) && (Btn2.Enabled == false))
            {
                win = true;
                if (Btn2.Text == "X")
                {
                    player = true;
                }
                else if (Btn2.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn0.Text == Btn4.Text) && (Btn4.Text == Btn8.Text) && (Btn0.Enabled == false))
            {
                win = true;
                if (Btn0.Text == "X")
                {
                    player = true;
                }
                else if (Btn0.Text == "O")
                {
                    player = false;
                }
            }
            else if ((Btn2.Text == Btn4.Text) && (Btn4.Text == Btn6.Text) && (Btn2.Enabled == false))
            {
                win = true;
                if (Btn2.Text == "X")
                {
                    player = true;
                }
                else if (Btn2.Text == "O")
                {
                    player = false;
                }
            }
            else
            {
                win = false;

            }

            turns++;

            if (win == true)
            {
                disableAllButtons();
                if (player == true)
                {
                    MessageBox.Show("X is the winner", "Winner");
                }
                else
                {
                    MessageBox.Show("O is the winner ", "Winner");

                }

                if (turns == 9)
                {
                    MessageBox.Show("Its a draw", "Draw");
                }
            }
        }
    }
}
