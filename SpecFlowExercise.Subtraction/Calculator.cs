using System;

namespace SpecFlowExercise.Subtraction
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
