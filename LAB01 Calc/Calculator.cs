using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_Calc
{
    public class Calculator
    {
        public decimal currentValue;

        //Variable to store current value when an operator button is pressed
        //Dont really understand what 'static' does but it fixed the problem where it would reset to 0 after a function is done running
        public static decimal operationVariable;

        //Using array to tell the equals function which operation is being used
        public string[] operationList = { "Addition", "Subtraction", "Multiplication", "Division" };

        //Again, set to 'static' because it keeps getting whiped out
        public static int operationIndex;



        //Constructor
        public Calculator(decimal enteredValue)
        {
            this.CurrentValue = enteredValue;
        }

        //Property to keep track of the result currently displayed by the calculator
        public decimal CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }

        }

        //Method to set operation to addition
        public void Add(string value)
        {
            operationIndex = 0;
            operationVariable = Convert.ToDecimal(value);
        }

        //Method to set operation to subtraction
        public void Subtract(string value)
        {
            operationIndex = 1;
            operationVariable = Convert.ToDecimal(value);
        }

        //Method to set operation to multiplication
        public void Multiply(string value)
        {
            operationIndex = 2;
            operationVariable = Convert.ToDecimal(value);
        }

        //Method to set operation to division
        public void Divide(string value)
        {
            operationIndex = 3;
            operationVariable = Convert.ToDecimal(value);
        }

        //Method to calculate the result of the numbers based on the operation
        public decimal Equals(string num)
        {
            decimal result = 0;
            if (operationIndex == 0)
            {
                //Use addition
                result = operationVariable + Convert.ToDecimal(num);
            }
            else if (operationIndex == 1)
            {
                //Use subtraction
                result = operationVariable - Convert.ToDecimal(num);
            }
            else if (operationIndex == 2)
            {
                //Use multiplication
                result = operationVariable * Convert.ToDecimal(num);
            }
            else if (operationIndex == 3)
            {
                //Use division
                result = operationVariable / Convert.ToDecimal(num);
            }

            return result;
        }

        //Get the reciprocal of the current value
        public decimal Reciprocal(string num)
        {
            decimal result;
            result = 1 / Convert.ToDecimal(num);
            return result;
        }
        //Get the square root of hte current value
        public double SqRt(string num)
        {
            double result;

            result = Math.Sqrt(Convert.ToDouble(num));
            return result;
        }

    }
}
