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


        Calculator calc = new Calculator(0);

        public Form1()
        {
            InitializeComponent();
        }
        //Plus Button 
        private void button3_Click(object sender, EventArgs e)
        {
            
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

        //Set the calculator screen their appropriate values based on the current value
        private void setField()
        {

            textBox1.Text += calc.CurrentValue;
        }
    }
}
