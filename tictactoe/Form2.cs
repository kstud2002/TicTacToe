using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        public static bool AI = false;
        int name = 1;
        public static string nameP1 = "Player 1";
        public static string nameP2 = "Player 2";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            new Form1().Show(this);
            //Hide();
            AI = true;
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {
            new Form1().Show(this);
            //Hide();
            AI = false;
        }

        private void btnEnterName_Click(object sender, EventArgs e)
        {
            if (name == 1)
            {
                btnEnterName.Text = "P2";
                name = 2;
                nameP1 = txtEnterName.Text;
                txtEnterName.Text = "";
            }
            else if (name == 2)
            {
                btnEnterName.Text = "P1";
                name = 1;
                nameP2 = txtEnterName.Text;
                txtEnterName.Text = "";
            }
        }
    }
}
