using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Calculator : CAlculatecs
    {
        public int minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int taghsim(int num1, int num2)
        {
            return num1 / num2;
        }

        public int zarb(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
