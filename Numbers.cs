using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SimpleCalculatorProject
{
    internal class Numbers
    {
        public int num0 { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int num4 { get; set; }
        public int num5 { get; set; }
        public int num6 { get; set; }
        public int num7 { get; set; }
        public int num8 { get; set; }
        public int num9 { get; set; }

        public bool Add { get; set; }
        public bool Minus { get; set; }
        public bool Divide { get; set; }
        public bool Multiply { get; set; }

        public int temp1 { get; set; }
        public int temp2 { get; set; }

        public string LogData { get; set; }

        public int GetAnswer(int input1, int input2) 
        {
            int result = 0;

            if (this.Add == true)
            {
                result = input1 + input2;
                return result;
            }
            else if (this.Minus == true)
            {
                result = input1 - input2;
                return result;
            }
            else if (this.Multiply == true)
            {
                result = input1 * input2;
                return result;
            }
            else if (this.Divide == true)
            {
                result = input1 / input2;
                return result;
            }
            else 
            {
                return 0;
            }
        }
        public void WriteLog(string input) 
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("log.txt", true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(input);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string ShowLog() 
        {
            try 
            {
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    this.LogData = sr.ReadToEnd();
                    sr.Close();
                }
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return this.LogData;
        }
    }
}
