using Arrays;
using System;
class Exercicio_6
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("\n***Vetor gerado***");
        Console.WriteLine("\nOs números aléatorios estão entre 1 e 10");
        //BibliotecaArray.mostravetor(meuvetor);

        int x = 0;

        Console.WriteLine("\nDigite um número negativo para encerrar o programa.");

        while (x >= 0)
        {
            Console.WriteLine("\nDigite um número:");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < meuvetor.Length; i++)
            {
                if (meuvetor[i] == x)
                {
                    Console.WriteLine($"O número ESTÁ contido na posição [{i}] do vetor.");
                }
                else
                {
                    Console.WriteLine($"O número não está contido na posição [{i}] do vetor.");
                }
            }
        }
    }
}
