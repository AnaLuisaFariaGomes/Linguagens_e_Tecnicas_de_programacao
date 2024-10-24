using System;
using Arrays;
class Exercicio_8
{
    static void Main ()
    {

        string caracteres;

        Console.WriteLine("Digite as letras que vão compor o vetor: ");
        caracteres = Console.ReadLine();

        int n = caracteres.Length;
        char[] vetor = new char[n];

        for (int i = 0; i < n; i++)
        {
            vetor[i] = caracteres[i];
        }

        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(vetor[i]);           
        }

    }
}
