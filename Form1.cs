using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        CAlculatecs calculate;
        public Form1()
        {
            calculate = new Calculator();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private bool validation()
        {
           if(firstNumber.Value == null && secondNumber.Value == null || firstNumber.Value == 0 && secondNumber.Value == 0) {
                MessageBox.Show("لطفا اعداد را وارد کنید.");
                return false;
            }

           return true;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (validation())
            {

            MessageBox.Show(calculate.sum(int.Parse(firstNumber.Value.ToString()),(int)secondNumber.Value).ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            firstNumber.Value = 0;
            secondNumber.Value = 0;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                MessageBox.Show(calculate.minus((int)firstNumber.Value, (int)secondNumber.Value).ToString());
            }

        }

        private void taghsimBtn_Click(object sender, EventArgs e)
        {
            if (validation()) {

                MessageBox.Show(calculate.taghsim((int) firstNumber.Value,(int)secondNumber.Value).ToString());

            }
        }

        private void zarbBtn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                MessageBox.Show(calculate.zarb((int)firstNumber.Value,(int) secondNumber.Value).ToString());
            }
        }
    }
}
