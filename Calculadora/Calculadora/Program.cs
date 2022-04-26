using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, escolha, resultado;

            Console.WriteLine("Bem vindo a calculadora: ");
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("");

            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Qual operação você deseja fazer? ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto");
            escolha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            if(escolha == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if(escolha == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (escolha == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (escolha == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine("O resultado é: " + resultado);
            }
            else if (escolha == 5)
            {
                resultado = num1 % num2;
                Console.WriteLine("O resultado é: " + resultado);
            }


            


        }
    }
}
