using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculationEngine
    {
        public int DoMath(string stuffToCalculate)
        {
            try
            {
                var splitNumbers = stuffToCalculate
                                    .Split("+") // Splits it at the + 
                                    .Select(int.Parse); // Turns string into integer and puts it into array

                return splitNumbers.Sum();
            }
            catch(FormatException)
            {
                throw new InvalidInputException();
            }
        }
    }
}
