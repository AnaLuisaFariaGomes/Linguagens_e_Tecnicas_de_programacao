using System;
using System.Security.Cryptography;
using Arrays;
class Exercicio10
{
    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de vezes que o dado será lançado: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        Console.WriteLine("\n**ATENÇÃO**\nDigite apenas os algarismos contidos no dado (1 a 6)");
        BibliotecaArray.leiavetor(meuvetor);
        BibliotecaArray.mostravetor(meuvetor);

        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;

        for (int i = 0; i < meuvetor.Length; i++)
        {
            if (meuvetor[i]== 1)
            {
                c1++;
            }
            if (meuvetor[i] == 2)
            {
                c2++;
            }
            if (meuvetor[i] == 3)
            {
                c3++;
            }
            if (meuvetor[i] == 4)
            {
                c4++;
            }
            if (meuvetor[i] == 5)
            {
                c5++;
            }
            if (meuvetor[i] == 6)
            {
                c6++;
            }
        }

        Console.WriteLine($"\nO número 1 aparece {c1} vezes.");
        Console.WriteLine($"\nO número 2 aparece {c2} vezes.");
        Console.WriteLine($"\nO número 3 aparece {c3} vezes.");
        Console.WriteLine($"\nO número 4 aparece {c4} vezes.");
        Console.WriteLine($"\nO número 5 aparece {c5} vezes.");
        Console.WriteLine($"\nO número 6 aparece {c6} vezes.");


    }
}
