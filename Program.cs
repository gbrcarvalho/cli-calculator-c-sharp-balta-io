using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine();
            Console.WriteLine("Selecione uma das opções acima: ");
            byte option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue + secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue - secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue / secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da divisão é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());
            float result = firstValue * secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da multiplicação é {result}");
            Console.ReadKey();
            Menu();
        }
    } 
}