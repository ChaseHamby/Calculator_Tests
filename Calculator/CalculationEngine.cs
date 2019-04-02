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
            var splitNumbers = stuffToCalculate.Split("+")
                .Select(int.Parse).ToArray(); // Turns string into integer and puts it into array

            return splitNumbers[0] + splitNumbers[1]; // adds first number and second number
        }
    }
}
