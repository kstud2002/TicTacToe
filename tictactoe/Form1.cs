using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool player = true;
        bool player1Win = false;
        bool player2Win = false;
        Random rnd = new Random();
        int AIpick;

        public Form1()
        {
            InitializeComponent();
        }
        //Spieler wechseln
        private void tmrChangePlayer_Tick(object sender, EventArgs e)
        {
            if (player)
            {
                BackColor = Color.Blue;
            }
            else
            {
                BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrChangePlayer.Start();
            tmrWin.Start();
            tmrAI.Start();
        }
        //
        private void btn1_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn1.Text = "X";
                btn1.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player && btn1.Enabled && btn1.Text != "X")
            {
                player = true;
                btn1.Text = "O";
                btn1.Enabled = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn2.Text = "X";
                btn2.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn2.Text = "O";
                btn2.Enabled = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn3.Text = "X";
                btn3.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn3.Text = "O";
                btn3.Enabled = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn4.Text = "X";
                btn4.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn4.Text = "O";
                btn4.Enabled = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn5.Text = "X";
                btn5.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn5.Text = "O";
                btn5.Enabled = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn6.Text = "X";
                btn6.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn6.Text = "O";
                btn6.Enabled = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn7.Text = "X";
                btn7.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn7.Text = "O";
                btn7.Enabled = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn8.Text = "X";
                btn8.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn8.Text = "O";
                btn8.Enabled = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (player)
            {
                player = false;
                btn9.Text = "X";
                btn9.Enabled = false;
                if (Form2.AI)
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
            else if (!player)
            {
                player = true;
                btn9.Text = "O";
                btn9.Enabled = false;
            }
        }
        private void btnReset_Click_1(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn1.Text = "";
            btn2.Enabled = true;
            btn2.Text = "";
            btn3.Enabled = true;
            btn3.Text = "";
            btn4.Enabled = true;
            btn4.Text = "";
            btn5.Enabled = true;
            btn5.Text = "";
            btn6.Enabled = true;
            btn6.Text = "";
            btn7.Enabled = true;
            btn7.Text = "";
            btn8.Enabled = true;
            btn8.Text = "";
            btn9.Enabled = true;
            btn9.Text = "";
            txtWin.Visible = false;
            player1Win = false;
            player2Win = false;
            AIpick = 0;
            tmrAI.Start();
            txtWin.Font = new Font("Microsoft sans serif", 28, FontStyle.Bold);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            txtWin.Font = new Font("Microsoft sans serif", 28, FontStyle.Bold);
            Hide();
        }

        private void tmrWin_Tick_1(object sender, EventArgs e)
        {
            //Spieler 1 Win
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                player1Win = true;
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                player1Win = true;
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                player1Win = true;
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                player1Win = true;
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                player1Win = true;
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                player1Win = true;
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                player1Win = true;
            }
            if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                player1Win = true;
            }

            //Spieler 2 Win
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                player2Win = true;
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                player2Win = true;
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                player2Win = true;
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                player2Win = true;
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                player2Win = true;
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                player2Win = true;
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                player2Win = true;
            }
            if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                player2Win = true;
            }
            //Win Message
            if (player1Win)
            {
                tmrAI.Stop();
                player = false;
                txtWin.Visible = true;
                txtWin.ForeColor = Color.Red;
                if (Form2.AI)
                {
                    txtWin.Text = "You Win!";
                }
                else
                {
                    txtWin.Text = Form2.nameP1 + " Wins!";
                }
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            if (player2Win)
            {
                player = true;
                txtWin.Visible = true;
                txtWin.ForeColor = Color.Blue;
                if (Form2.AI)
                {
                    txtWin.Text = "You lost against a Bot!";
                    txtWin.Font = new Font("Microsoft sans serif", 15, FontStyle.Bold);
                }
                else
                {
                    txtWin.Text = Form2.nameP2 + " Wins!";
                }
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
        }

        private void tmrAI_Tick_1(object sender, EventArgs e)
        {
            if (!player && Form2.AI == true)
            {
                if (!player && AIpick == 1 && btn1.Text != "X" && btn1.Text != "O")
                {
                    player = true;
                    btn1.Text = "O";
                    btn1.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 2 && btn2.Text != "X" && btn2.Text != "O")
                {
                    player = true;
                    btn2.Text = "O";
                    btn2.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 3 && btn3.Text != "X" && btn3.Text != "O")
                {
                    player = true;
                    btn3.Text = "O";
                    btn3.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 4 && btn4.Text != "X" && btn4.Text != "O")
                {
                    player = true;
                    btn4.Text = "O";
                    btn4.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 5 && btn5.Text != "X" && btn5.Text != "O")
                {
                    player = true;
                    btn5.Text = "O";
                    btn5.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 6 && btn6.Text != "X" && btn6.Text != "O")
                {
                    player = true;
                    btn6.Text = "O";
                    btn6.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 7 && btn7.Text != "X" && btn7.Text != "O")
                {
                    player = true;
                    btn7.Text = "O";
                    btn7.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 8 && btn8.Text != "X" && btn8.Text != "O")
                {
                    player = true;
                    btn8.Text = "O";
                    btn8.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
                if (!player && AIpick == 9 && btn9.Text != "X" && btn9.Text != "O")
                {
                    player = true;
                    btn9.Text = "O";
                    btn9.Enabled = false;
                }
                else
                {
                    AIpick = rnd.Next(1, 10);
                }
            }
        }
    }
}
