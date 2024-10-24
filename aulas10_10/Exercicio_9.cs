using System;
using Arrays;
class Exercicio_9
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor os vetores: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        int x=0, cont=0;

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("\n***Vetor gerado***");
        Console.WriteLine("\nOs números aléatorios estão entre 1 e 10");
        BibliotecaArray.mostravetor(meuvetor);

        Console.WriteLine("\nDigite um número negativo para encerrar o programa.");

        while (x >= 0)
        {
            Console.WriteLine("\nDigite um número:");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < meuvetor.Length; i++)

                if (meuvetor[i] == x)
                {
                    cont++;
                }
            Console.WriteLine($"\nO número {x} aparece {cont} vezes.");
        }
    }
}


