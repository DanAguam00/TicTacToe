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
            Btn0.BackColor = Color.Red;
            Winner();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Btn1.Text = "X";
            Winner();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Btn2.Text = "X";
            Winner();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Btn3.Text = "X";
            Winner();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Btn4.Text = "X";
            Winner();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Btn5.Text = "X";
            Winner();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Btn6.Text = "X";
            Winner();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Btn7.Text = "X";
            Winner();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Btn8.Text = "X";
            Winner();
        }

        private void Winner()
        {
            bool win = false;
            if ((Btn0.Text == Btn1.Text) && (Btn1.Text == Btn2.Text))
            {
                win = true;
            }
            else if ((Btn3.Text == Btn4.Text) && (Btn4.Text == Btn5.Text))
            {
                win = true;
            }
            else if ((Btn6.Text == Btn7.Text) && (Btn7.Text == Btn8.Text))
            {
                win = true;
            }
            else if ((Btn0.Text == Btn3.Text) && (Btn3.Text == Btn6.Text))
            {
                win = true;
            }
            else if ((Btn1.Text == Btn4.Text) && (Btn4.Text == Btn7.Text))
            {
                win = true;
            }
            else if ((Btn2.Text == Btn5.Text) && (Btn5.Text == Btn8.Text))
            {
                win = true;
            }
            else if ((Btn0.Text == Btn4.Text) && (Btn4.Text == Btn8.Text))
            {
                win = true;
            }
            else if ((Btn2.Text == Btn4.Text) && (Btn4.Text == Btn6.Text))
            {
                win = true;
            }


            if (win == true)
            {
                MessageBox.Show("Winner");
            }
        }
    }
}
