using Arrays;
using System;
class Exercicio_1
{
    static int somavetor (int[] vetor)
    {
        //percorrer e somar, retorne a soma
        int soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        return soma;
    }//fim soma vetor
    static void Main()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor);

        Console.WriteLine("\nSoma do vetor: ");
        Console.WriteLine($"{somavetor(meuvetor)}");

        Console.ReadKey();
    }
}
