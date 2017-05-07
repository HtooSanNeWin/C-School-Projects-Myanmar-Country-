using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2017050701_CS_ExamMarking
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCal_Click(object sender, EventArgs e)
        {
            int fail = 0;
            int high = 0;
            int total = 0;
            int[] mid = new int[6];

            if ((txtName.Text != "") && (txtMyanmar.Text != "") && (txtEnglish.Text != "") && (txtMath.Text != "") && (txtPhysics.Text != "") && (txtChem.Text != "") && (txtBio.Text != ""))
            {
                int MyanMark = int.Parse(txtMyanmar.Text.ToString());
                int EngMark = int.Parse(txtEnglish.Text.ToString());
                int MathMark = int.Parse(txtMath.Text.ToString());
                int PhysicsMark = int.Parse(txtPhysics.Text.ToString());
                int ChemMark = int.Parse(txtChem.Text.ToString());
                int BioMark = int.Parse(txtBio.Text.ToString());

                int[] Mark = new int[6];
                int[] LowMarks = new int[6];
                int[] HighMarks = new int[6];

                for (int i = 0; i < Mark.Length; i++)
                {
                    if (i == 0)
                    {
                        if (MyanMark > 39 && MyanMark < 80) { Mark[i] = MyanMark; mid[0] = 1; }
                        if (MyanMark < 40) { LowMarks[0] = 1; fail += 1; Mark[i] = MyanMark; }
                        if (MyanMark > 79) { HighMarks[0] = 1; high += 1; Mark[i] = MyanMark; }

                    }
                    if (i == 1)
                    {
                        if (EngMark > 39 && EngMark < 80) { Mark[i] = EngMark; mid[1] = 1; }
                        if (EngMark < 40) { LowMarks[1] = 1; fail += 1; Mark[i] = EngMark; }
                        if (EngMark > 79) { HighMarks[1] = 1; high += 1; Mark[i] = EngMark; }

                    } if (i == 2)
                    {
                        if (MathMark > 39 && MathMark < 80) { Mark[i] = MathMark; mid[2] = 1; }
                        if (MathMark < 40) { LowMarks[2] = 1; fail += 1; Mark[i] = MathMark; }
                        if (MathMark > 79) { HighMarks[2] = 1; high += 1; Mark[i] = MathMark; }

                    } if (i == 3)
                    {
                        if (PhysicsMark > 39 && PhysicsMark < 80) { Mark[i] = PhysicsMark; mid[3] = 1; }
                        if (PhysicsMark < 40) { LowMarks[3] = 1; fail += 1; Mark[i] = PhysicsMark; }
                        if (PhysicsMark > 79) { HighMarks[3] = 1; high += 1; Mark[i] = PhysicsMark; }

                    } if (i == 4)
                    {
                        if (ChemMark > 39 && ChemMark < 80) { Mark[i] = ChemMark; mid[4] = 1; }
                        if (ChemMark < 40) { LowMarks[4] = 1; fail += 1; Mark[i] = ChemMark; }
                        if (ChemMark > 79) { HighMarks[4] = 1; high += 1; Mark[i] = ChemMark; }

                    } if (i == 5)
                    {
                        if (BioMark > 39 && BioMark < 80) { Mark[i] = BioMark; mid[5] = 1; }
                        if (BioMark < 40) { LowMarks[5] = 1; fail += 1; Mark[i] = BioMark; }
                        if (BioMark > 79) { HighMarks[5] = 1; high += 1; Mark[i] = BioMark; }

                    }
                    total += Mark[i];


                }
                if (LowMarks[0] == 1)
                {
                    MessageBox.Show("You Fail Myanmar!");
                }
                if (LowMarks[1] == 1)
                {
                    MessageBox.Show("You Fail English!");
                }
                if (LowMarks[2] == 1)
                {
                    MessageBox.Show("You Fail Mathemathics!");
                }
                if (LowMarks[3] == 1)
                {
                    MessageBox.Show("You Fail Physics!");
                }
                if (LowMarks[4] == 1)
                {
                    MessageBox.Show("You Fail Chemistry!");
                }
                if (LowMarks[5] == 1)
                {
                    MessageBox.Show("You Fail Biology!");
                }
                if (mid[0] == 1)
                {
                    MessageBox.Show("You Pass Myanmar!");
                }
                if (mid[1] == 1)
                {
                    MessageBox.Show("You Pass English!");
                }
                if (mid[2] == 1)
                {
                    MessageBox.Show("You Pass Mathemathics!");
                }
                if (mid[3] == 1)
                {
                    MessageBox.Show("You Pass Physics!");
                }
                if (mid[4] == 1)
                {
                    MessageBox.Show("You Pass Chemistry!");
                }
                if (mid[5] == 1)
                {
                    MessageBox.Show("You Pass Biology!");
                }
                if (HighMarks[0] == 1)
                {
                    MessageBox.Show("You Have High Marks in Myanmar!");
                }
                if (HighMarks[1] == 1)
                {
                    MessageBox.Show("You Have High Marks in English!");
                }
                if (HighMarks[2] == 1)
                {
                    MessageBox.Show("You Have High Marks in Mathemathics!");
                }
                if (HighMarks[3] == 1)
                {
                    MessageBox.Show("You Have High Marks in Physics!");
                }
                if (HighMarks[4] == 1)
                {
                    MessageBox.Show("You Have High Marks in Chemistry!");
                }
                if (HighMarks[5] == 1)
                {
                    MessageBox.Show("You Have High Marks in Biology!");
                }
                if (total > 479)
                {
                    MessageBox.Show("Congrats You Pass the Examination with 'A' Grade!");
                }
                if (total < 480 && total > 359)
                {
                    MessageBox.Show("Well You Pass the Examination with 'B' Grade!");
                }
                if (total < 360 && total > 239)
                {
                    MessageBox.Show("Congrats You Pass the Examination with 'C' Grade!");
                }
                if (fail >= 1)
                {
                    MessageBox.Show("Sorry, You Pass the Examination with 'D' Grade!");
                }
            }
            else
            {
                MessageBox.Show("Need to fill all require fields");
            }
        }
    }
}

