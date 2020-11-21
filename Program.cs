using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = {"pera", "abacaxi", "beterraba", "feijão", "arroz",};
            // double[] precos = {1.1, 2.3, 4.5};
            // int[] idade = {16, 17, 17};
            // int[] array = new int[5] {1, 3, 7, 12, 8};
            // string[] nomesAlunos = new string[5];

            // Console.WriteLine(produtos[1]);

            // // Console.WriteLine("Trocar batata por qual item?");

            // produtos[1] = Console.ReadLine();

            // Console.WriteLine("O produto foi trocado por: ");

            // Console.WriteLine(produtos[1]);

            for (var i = 0; i < produtos.Length; i++)
            {
                 Console.WriteLine(produtos[i]);
                 
            }
        }
    }
}
