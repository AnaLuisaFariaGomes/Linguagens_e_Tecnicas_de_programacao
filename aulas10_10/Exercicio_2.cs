using System;
using Arrays;

class Exercicio_2
{
    static double maiorvetor(double[] vetor)
    {
        double maior = vetor[1];

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        return maior;
    }//fim maior vetor

    static void Main ()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());

        double[] meuvetor = new double[n];

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor);

        Console.WriteLine("\nMaior elemento do vetor: ");
        Console.WriteLine($"{maiorvetor(meuvetor):F2}");

        Console.ReadKey();
    }
}

