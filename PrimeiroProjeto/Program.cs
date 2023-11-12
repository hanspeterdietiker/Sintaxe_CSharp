using System;
using System.Globalization;

// Sintaxe C#

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            stractureFor();
            entradaDeDados();
            sintaxeToString();
            testInterpolação();
        }

        public static void stractureFor()
        {
            Console.Write("Quantos numeros voce deseja inserir?");
            int numeroFor = int.Parse(Console.ReadLine());
            
            int soma = 0;
            for (int i = 1; i <= numeroFor; i++)
            {
                Console.WriteLine("Informe o numero " + i);
                int testFor = int.Parse(Console.ReadLine());

                Console.WriteLine(testFor);
                soma += testFor;
                Console.WriteLine("-----------------FOR--------------------");
            }
                Console.WriteLine("soma dos numeros é:" + soma);
        }


        public static void entradaDeDados()
        {
            string frase = Console.ReadLine();
            Console.WriteLine(frase);
            Console.WriteLine("-------------------------------------");

            int entradaDeInt = int.Parse(Console.ReadLine());
            Console.WriteLine(entradaDeInt);
            Console.WriteLine("-------------------------------------");

            float entradaDeDecimal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(entradaDeDecimal);
            Console.WriteLine("-------------------------------------");
        }

        public static void sintaxeToString()
        {
            double saldo = 37.4444;
            Console.WriteLine(saldo.ToString("F1"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("-------------------------------------");
        }


        public static void testInterpolação()
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine("{0}, tem {1} anos e tem saldo igual a {2:F2}", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2}");
        }
    }
}