using System;
using Arrays;
class Exercicio_4
{
    static int quantimparvetor(int[] vetor)
    {
        int cont=0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i]%2!=0)
            {
                cont++;
            }
        }

        return cont;
    }//fim maior vetor

    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor);

        Console.WriteLine("\nNúmero de elementos ímpares do vetor: ");
        Console.WriteLine($"{quantimparvetor(meuvetor)}");

        Console.ReadKey();
    }
}

