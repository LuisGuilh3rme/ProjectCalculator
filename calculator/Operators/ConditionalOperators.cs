using System;
using System.Globalization;

namespace calculator.Operators
{
    public class ConditionalOperators
    {
        public string Sum(double FirstValue, double SecondValue)
        {
            double result = FirstValue + SecondValue;
            return $"{FirstValue} + {SecondValue} = {result.ToString("F2", CultureInfo.InvariantCulture)}";    
        }

        public string Subtraction(double FirstValue, double SecondValue)
        {
            double result = FirstValue - SecondValue;
            return $"{FirstValue} - {SecondValue} = {result.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Multiplication(double FirstValue, double SecondValue)
        {
            double result = FirstValue * SecondValue;
            return $"{FirstValue} * {SecondValue} = {result.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Division(double FirstValue, double SecondValue)
        {
            double result = FirstValue / SecondValue;
            return $"{FirstValue} / {SecondValue} = {result.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public string Exponentialisation(double BaseValue, double UpperValue)
        {
            double result = Math.Pow(BaseValue, UpperValue);
            return $"{BaseValue} ** {UpperValue} = {result.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
