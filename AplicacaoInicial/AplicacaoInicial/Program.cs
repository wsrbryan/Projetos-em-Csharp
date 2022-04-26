using System;

namespace AplicacaoInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, peso;
            string nome;
            double altura, imc;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bem vindo " + nome);

            Console.WriteLine("");

            Console.WriteLine("Agora vamos calcular seu IMC");

            Console.WriteLine("");

            Console.WriteLine("Digite sua altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu peso:");
            peso = Convert.ToInt32(Console.ReadLine());

            imc = 100 *(peso / (altura * 2));

            Console.WriteLine("Seu imc é de: " + imc);

        }
    }
}
