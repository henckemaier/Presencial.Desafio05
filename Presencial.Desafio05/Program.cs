using System;

namespace Desafio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Repetimento de numeros====");
            //valores
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };

            if (array.Length > 2000)
            {
                Console.WriteLine("O máximo de valores permitido é 2000");
            }

            for (int i = 0; i < array.Length;/*<- até o fim do array*/ i++)
            {
                int contagem = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        contagem = contagem + 1;
                }

                Console.WriteLine("\n" + array[i] + " repete: " + contagem + " vezes.");
            }
        }
    }
}
