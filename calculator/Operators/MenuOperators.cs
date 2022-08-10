using calculator.Interfaces;
using System;

namespace calculator.Operators
{
    public class MenuOperators : IMenuOperators
    {
        public string Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem - vindo a Calculadora!");
            Console.WriteLine("Escolha uma das opções de calculo a baixo!\n");

            Console.WriteLine("|------------------|");
            Console.WriteLine("|SOMA          [1] |");
            Console.WriteLine("|SUBTRAÇÃO     [2] |");
            Console.WriteLine("|MULTIPLICAÇÃO [3] |");
            Console.WriteLine("|DIVISÃO       [4] |");
            Console.WriteLine("|EXPONENCIAÇÃO [5] |");
            Console.WriteLine("|                  |");
            Console.WriteLine("|SAIR          [0] |");
            Console.WriteLine("|------------------|");

            string choose = Console.ReadLine();
            return choose;
        }


    }
}
