using System;
using Arrays;
class Exercicio_7
{
    //multiplicação de cada posição das matrizes e armazenando em um 3° vetor
    public static void multiplicacaovetor(int n,int[] vetor1, int[] vetor2, int[] vetor3)
    {
        for (int i = 0; i < n; i++)
        {
            vetor3[i] = vetor1[i] * vetor2[i];
        }
    }//fim da função
    static void Main()
    {
        //primeiro vetor
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor os vetores: ");
        n = int.Parse(Console.ReadLine());

        int[] meuvetor = new int[n];

        //segundo vetor
        int[] meuvetor1 = new int[n];

        //terceiro vetor (vetor resultado)   
        int[] meuvetor2 = new int[n];


        BibliotecaArray.geravetor(meuvetor);
        Console.WriteLine("\n***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor);

        BibliotecaArray.geravetor(meuvetor1);
        Console.WriteLine("\n***Vetor gerado***");
        BibliotecaArray.mostravetor(meuvetor1);

        //chamando função para fazer a multiplicação
        Exercicio_7.multiplicacaovetor(n, meuvetor, meuvetor1, meuvetor2);

        // Exibe o vetor resultado
        Console.WriteLine("\nVetor da multiplicação:");
        BibliotecaArray.mostravetor(meuvetor2);

        Console.ReadKey();
    }
}

