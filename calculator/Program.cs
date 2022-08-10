using calculator.Operators;
using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuOption = "";
            var conditions = new ConditionalOperators();
            var conditionsUser = new UserOperators();
            var conditionsMenu = new MenuOperators();

            do
            {
                menuOption = conditionsMenu.Menu();
                Console.Clear();
                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine(conditions.Sum(conditionsUser.FirstValueUser(), conditionsUser.SecondValueUser()));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine(conditions.Subtraction(conditionsUser.FirstValueUser(), conditionsUser.SecondValueUser()));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine(conditions.Multiplication(conditionsUser.FirstValueUser(), conditionsUser.SecondValueUser()));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(conditions.Division(conditionsUser.FirstValueUser(), conditionsUser.SecondValueUser()));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine(conditions.Exponentialisation(conditionsUser.FirstValueUser(), conditionsUser.SecondValueUser()));
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Seu software foi finalizado com sucesso!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente!");
                        Console.ReadKey();
                        break;
                }
            } while (menuOption != "0");
        }
    }
}
