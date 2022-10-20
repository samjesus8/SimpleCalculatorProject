using System;
using System.Windows.Forms;

namespace SimpleCalculatorProject
{
    public partial class MAIN : Form
    {
        Numbers numbers = new Numbers();

        public MAIN()
        {
            InitializeComponent();
        }

        private void B0_Click(object sender, EventArgs e)
        {
            numbers.num0 = 0;
            outputBox.Text = outputBox.Text + "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            numbers.num1 = 1;
            outputBox.Text = outputBox.Text + "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            numbers.num2 = 2;
            outputBox.Text = outputBox.Text + "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            numbers.num3 = 3;
            outputBox.Text = outputBox.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            numbers.num4 = 4;
            outputBox.Text = outputBox.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            numbers.num5 = 5;
            outputBox.Text = outputBox.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            numbers.num6 = 6;
            outputBox.Text = outputBox.Text + "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            numbers.num7 = 7;
            outputBox.Text = outputBox.Text + "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            numbers.num8 = 8;
            outputBox.Text = outputBox.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            numbers.num9 = 9;
            outputBox.Text = outputBox.Text + "9";
        }

        private void equalsButton_Click(object sender, EventArgs e) //Outputs Answer
        {
            numbers.temp2 = int.Parse(outputBox.Text);
            int result = numbers.GetAnswer(numbers.temp1, numbers.temp2);
            string log = numbers.temp1.ToString() + " " + numbers.tempFunction + " " + numbers.temp2.ToString() + " = " + result + " | " + DateTime.Now.ToString();

            numbers.WriteLog(log);

            outputBox.Text = result.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            numbers.temp1 = int.Parse(outputBox.Text);
            outputBox.Clear();

            numbers.Add = true;
            numbers.Minus = false;
            numbers.Multiply = false;
            numbers.Divide = false;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            numbers.temp1 = int.Parse(outputBox.Text);
            outputBox.Clear();

            numbers.Add = false;
            numbers.Minus = false;
            numbers.Multiply = true;
            numbers.Divide = false;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            numbers.temp1 = int.Parse(outputBox.Text);
            outputBox.Clear();

            numbers.Add = false;
            numbers.Minus = true;
            numbers.Multiply = false;
            numbers.Divide = false;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            numbers.temp1 = int.Parse(outputBox.Text);
            outputBox.Clear();

            numbers.Add = false;
            numbers.Minus = false;
            numbers.Multiply = false;
            numbers.Divide = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            logBox.Clear();
            numbers.ClearLog();

            numbers.temp1 = 0;
            numbers.temp2 = 0;
        }

        private void viewLogButton_Click(object sender, EventArgs e)
        {
            logBox.Text = numbers.ShowLog();
        }
    }
}
