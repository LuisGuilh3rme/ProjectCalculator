using System;

namespace calculator.Operators
{
    public class UserOperators
    {
        public double FirstValueUser()
        {
            Console.WriteLine("Digite o primeiro valor");
            double value = double.Parse(Console.ReadLine().Replace('.', ','));
            return value;
        }
        public double SecondValueUser()
        {
            Console.WriteLine("Digite o segundo valor");
            double value = double.Parse(Console.ReadLine().Replace('.', ','));
            return value;
        }
    }
}
