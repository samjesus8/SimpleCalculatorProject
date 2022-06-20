using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorProject
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, EventArgs e)
        {
            int value = 0;
            outputBox.Text = "0";          
        }

        private void B1_Click(object sender, EventArgs e)
        {
            int value = 1;
            outputBox.Text = "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            int value = 2;
            outputBox.Text = "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            int value = 3;
            outputBox.Text = "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            int value = 4;
            outputBox.Text = "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            int value = 5;
            outputBox.Text = "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            int value = 6;
            outputBox.Text = "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            int value = 7;
            outputBox.Text = "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            int value = 8;
            outputBox.Text = "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            int value = 9;
            outputBox.Text = "9";
        }
    }
}
