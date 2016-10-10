using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01_Calc
{
    public partial class Form1 : Form
    {

        //Declare class
        Calculator calc = new Calculator(0);

        //Declare variable to be used to store string of inputed numbers
        public string calcView = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Disable buttons that dont currently work
            //btnSquare.Enabled = false;
            //btnDecimal.Enabled = false;
            //btnNegative.Enabled = false;
            //bntInverse.Enabled = false;
        }



        //Num 0 Button 
        private void btn0_Click(object sender, EventArgs e)
        {
            calc = new Calculator(0);
            setField();
        }

        //Num 1 Button 
        private void btn1_Click(object sender, EventArgs e)
        {
            calc = new Calculator(1);
            setField();
        }
        //Num 2 Button 
        private void btn2_Click(object sender, EventArgs e)
        {
            calc = new Calculator(2);
            setField();
        }
        //Num 3 Button 
        private void btn3_Click(object sender, EventArgs e)
        {
            calc = new Calculator(3);
            setField();
        }
        //Num 4 Button 
        private void btn4_Click(object sender, EventArgs e)
        {
            calc = new Calculator(4);
            setField();
        }
        //Num 5 Button 
        private void btn5_Click(object sender, EventArgs e)
        {
            calc = new Calculator(5);
            setField();
        }
        //Num 6 Button 
        private void btn6_Click(object sender, EventArgs e)
        {
            calc = new Calculator(6);
            setField();
        }
        //Num 7 Button 
        private void btn7_Click(object sender, EventArgs e)
        {
            calc = new Calculator(7);
            setField();
        }
        //Num 8 Button 
        private void btn8_Click(object sender, EventArgs e)
        {
            calc = new Calculator(8);
            setField();
        }
        //Num 9 Button 
        private void bnt9_Click(object sender, EventArgs e)
        {
            calc = new Calculator(9);
            setField();
        }

        //Plus Button 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Add(calcView);
            }
            catch (FormatException)
            {

            }

            //Clean up the calcView variable
            calcView = "";
        }
        //Minus Button 
        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Subtract(calcView);
            }
            catch (FormatException)
            {

            }

            //Clean up the calcView variable
            calcView = "";
        }
        //Multiply Button 
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Multiply(calcView);
            }
            catch (FormatException)
            {

            }

            //Clean up the calcView variable
            calcView = "";
        }
        //Divide Button 
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Divide(calcView);
            }
            catch (FormatException)
            {

            }
            //Clean up the calcView variable
            calcView = "";
        }
        //Square Root Button
        private void btnSquare_Click(object sender, EventArgs e)
        {
            try
            {
                txtCalcView.Text = Convert.ToString(calc.SqRt(calcView));
            }
            catch (FormatException)
            {

            }
            //Clean up the calcView variable
            calcView = "";
        }
        //Inverse button
        private void bntInverse_Click(object sender, EventArgs e)
        {
            try
            {
                txtCalcView.Text = Convert.ToString(calc.reciprocal(calcView));
            }
            catch (FormatException)
            {

            }

            //Clean up the calcView variable
            calcView = "";

        }
        //Equals button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                calcView = Convert.ToString(calc.Equals(calcView));
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by zero!", "Error!");
            }
            txtCalcView.Text = calcView;

            //Clean up the calcView variable
            calcView = "";
        }
        //Decimal Button
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //Call method from class to add decimal value
            calcView = Convert.ToString(calc.decimalPoint());
            txtCalcView.Text = calcView;
        }
        //Negative button
        private void btnNegative_Click(object sender, EventArgs e)
        {
            decimal negativeConversion;
            try
            {
                negativeConversion = Convert.ToDecimal(calcView) * -1;

                calcView = Convert.ToString(negativeConversion);
            }
            catch (FormatException)
            {

            }
            txtCalcView.Text = calcView;

        }

        //Button that clears the calculator view box 
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Straight forward clearing of the calculator
            calcView = "";
            txtCalcView.Text = "";
        }
        //Button to backspace the calcView
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            //Remove the last diget of the calcView variable to act as a backspace button
            try
            {
                calcView = calcView.Remove(calcView.Length - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                //To many backspaces
            }
            txtCalcView.Text = calcView;

        }



        //Methods 

        //Set the calculator screen their appropriate values based on the current value
        private void setField()
        {
            calcView += calc.CurrentValue;
            txtCalcView.Text = calcView;
        }


    }
}
