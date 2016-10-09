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
            calc.Add(calcView);
        }
        //Minus Button 
        private void btnMinus_Click(object sender, EventArgs e)
        {

        }
        //Multiply Button 
        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }
        //Divide Button 
        private void btnDivide_Click(object sender, EventArgs e)
        {

        }
        //Square Root BUtton
        private void btnSquare_Click(object sender, EventArgs e)
        {

        }
        //Inverse button
        private void bntInverse_Click(object sender, EventArgs e)
        {

        }
        //Equals button
        private void btnEquals_Click(object sender, EventArgs e)
        {

        }
        //Decimal Button
        private void btnDecimal_Click(object sender, EventArgs e)
        {

        }
        //Negative button
        private void btnNegative_Click(object sender, EventArgs e)
        {

        }

        //Button that clears the calculator view box 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCalcView.Text = "";
        }
        //Button to backspace the calcView
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            calcView = calcView.Remove(calcView.Length - 1);
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
