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
        public decimal enteredValue;

        //Using array to tell the equals function which operation is being used
        public string[] operationList = { "Addition", "Subtraction", "Multiplication", "Division" };
        public int operationIndex = 0;

        //Variable to store current value when an operator button is pressed
        public decimal operationVariable;

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

        //Method to keep the 2 entered values
        public decimal EnteredValues()
        {
            return enteredValue;
        }
        //Method to set operation to addition
        public decimal Add(string value)
        {

            operationVariable = CurrentValue;

            return 323;
        }

        //Method to set operation to subtraction
        public decimal Subtract()
        {
            return 323;
        }

        //Method to set operation to multiplication
        public decimal Multiply()
        {
            return 323;
        }

        //Method to set operation to division
        public decimal Divide()
        {
            return 323;
        }

        //Method to calculate the result of the numbers based on the operation
        public decimal Equals()
        {
            return 323;
        }

        //Get the reciprocal of the current value
        public decimal Reciprocal()
        {
            return 323;
        }
        //Get the square root of hte current value
        public decimal SqRt()
        {
            return 323;
        }



    }
}
