using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Numbers() 
        {

        }

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
    }
}
