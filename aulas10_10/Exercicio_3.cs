using System;
using Arrays;
class Exercicio_3
{
    static double menorvetor(double[] vetor)
    {
        double menor = vetor[1];

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }//fim maior vetor

    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());

        double[] meuvetor = new double[n];

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor);

        Console.WriteLine("\nMenor elemento do vetor: ");
        Console.WriteLine($"{menorvetor(meuvetor):F2}");

        Console.ReadKey();
    }
}

