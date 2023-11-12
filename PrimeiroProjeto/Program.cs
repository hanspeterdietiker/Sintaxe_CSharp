using System;
using System.Globalization;

// Sintaxe C#

namespace PrimeiroProjeto

{
    internal class Program
    {
        static void Main(string[] args)
        {
            sintaxeToString();
            testInterpolação();
        }

        public static void sintaxeToString()
        {
            double saldo = 37.4444;
            Console.WriteLine(saldo.ToString("F1"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            
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