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

        //Constructor
        public Calculator()
        {
            this.CurrentValue = currentValue;
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
        public decimal EnteredValue()
        {
            return 0.0m;
        }
        //Method to set operation to addition
        public decimal Add()
        {
            return 0.0m;
        }

        //Method to set operation to subtraction
        public decimal Subtract()
        {
            return 0.0m;
        }

        //Method to set operation to multiplication
        public decimal Multiply()
        {
            return 0.0m;
        }

        //Method to set operation to division
        public decimal Divide()
        {
            return 0.0m;
        }

        //Method to calculate the result of the numbers based on the operation
        public decimal Equals()
        {
            return 0.0m;
        }

        //Get the reciprocal of the current value
        public decimal Reciprocal()
        {
            return 0.0m;
        }
        //Get the square root of hte current value
        public decimal SqRt()
        {
            return 0.0m;
        }

        //Clear the fields
        public void Clear()
        {

        }

    }
}
