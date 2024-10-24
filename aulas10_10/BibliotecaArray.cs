using System;

namespace Arrays
{
    public class BibliotecaArray
    {
        //leia vetor int
        public static void leiavetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"\nDigite o 1° valor (armazenado na posição [{i}] do vetor): ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }//fim leia vetor int

        //leia vetor double
        public static void leiavetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"\nDigite o 1° valor (armazenado na posição [{i}] do vetor): ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
        }//fim leia vetor double

        //mostra vetor int
        public static void mostravetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]} |");
            }
        }//fim mostra vetor int

        //mostra vetor double
        public static void mostravetor(double[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"| {vetor[i]:F2} |");
            }
        }//fim mostra vetor double

        //gera vetor double
        public static void geravetor(double[] vetor)
        {
            Random random = new Random(); //gerador aleatório
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 11) + random.NextDouble(); ;
            }
        }//fim gera vetor double

        //gera vetor int
        public static void geravetor(int[] vetor)
        {
            Random random = new Random(); //gerador aleatório
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 11);
            }
        }//fim gera vetor int

    }
}
