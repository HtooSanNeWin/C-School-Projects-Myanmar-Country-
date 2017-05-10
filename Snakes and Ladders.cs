using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game1_2017050901_CS
{
    public partial class Form1 : Form
    {
        int p1 = 0;
        int p2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnp2r_Click(object sender, EventArgs e)
        {
            
            Random dice = new Random();
            int roll = dice.Next(1, 7);

            p2 += roll;

            txtp2.Text = p2.ToString();
            if(p2==4)
            {
                p2 = 25;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 29)
            {
                p2 = 55;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 39)
            {
                p2 = 67;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 70)
            {
                p2 = 90;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 27)
            {
                p2 = 41;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 60)
            {
                p2 = 97;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 21)
            {
                p2 = 8;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 30)
            {
                p2 = 10;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 44)
            {
                p2 = 20;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 78)
            {
                p2 = 66;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 89)
            {
                p2 = 49;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 98)
            {
                p2 = 2;
                txtp2.Text = p2.ToString();
            }
            if (p2 == 100)
            {
                MessageBox.Show("Player 2 is the winner");
                txtp1.Text = " ";
                txtp2.Text = " ";
                p1 = 0;
                p2 = 0;
            }
            if (p2 > 100)
            {
                int p2ov = p2 - 100;
                int p2os = 100 - p2ov;
                p2 = p2os;
                txtp2.Text = p2os.ToString();
            }
            
        }

        private void btnp1r_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);

            p1 += roll;

            txtp1.Text = p1.ToString();
            if (p1 == 4)
            {
                p1 = 25;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 29)
            {
                p1 = 55;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 39)
            {
                p1 = 67;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 70)
            {
                p1 = 90;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 27)
            {
                p1 = 41;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 60)
            {
                p1 = 97;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 21)
            {
                p1 = 8;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 30)
            {
                p1 = 10;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 44)
            {
                p1 = 20;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 78)
            {
                p1 = 66;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 89)
            {
                p1 = 49;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 98)
            {
                p1 = 2;
                txtp1.Text = p1.ToString();
            }
            if (p1 == 100)
            {
                MessageBox.Show("Player 1 is the winner");
                txtp1.Text = " ";
                txtp2.Text = " ";
                p1 = 0;
                p2 = 0;
            }
            if (p1 > 100)
            {
                int p1ov = p1 - 100;
                int p1os = 100 - p1ov;
                p1 = p1os;
                txtp1.Text = p1os.ToString();
            }
        }
    }
}