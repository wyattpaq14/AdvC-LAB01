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

        //
        public string EnterValue()
        {

        }







    }
}
