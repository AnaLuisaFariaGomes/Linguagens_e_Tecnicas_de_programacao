using System;
using Arrays;
using static System.Net.Mime.MediaTypeNames;
class Exercicio_5
{
    static void Main ()
    {
        int n;

        Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
        n = int.Parse(Console.ReadLine());
        
        //nesse caso p while n é necessário, mas eu coloquei. Se necessário pode apagar ou comentar esse pedaço.
        while (n > 50)
        {
            Console.WriteLine("O limite do vetor é 50, tente novamente!");
            Console.WriteLine("Digite o número (inteiro) de elementos que vão compor o vetor: ");
            n = int.Parse(Console.ReadLine());
        }
        char[] vetor = new char[n];
        char[] vetor1 = new char[n];

        char valor;

        for(int i = 0;i < n; i++)
        {
            Console.WriteLine("Digite as letras A, T , C e G: ");
            vetor[i] = char.Parse(Console.ReadLine().ToUpper());

            if (vetor[i] == 'A')
            {
                Console.WriteLine($"\n{vetor[i]} | T");
                vetor1[i] = 'T';
            }
            else if(vetor[i] == 'T')
            {
                Console.WriteLine($"\n{vetor[i]} | A");
                vetor1[i] = 'A';
            }
            else if (vetor[i] == 'G')
            {
                Console.WriteLine($"\n{vetor[i]} | C");
                vetor1[i] = 'C';
            }
            else if (vetor[i] == 'C')
            {
                Console.WriteLine($"\n{vetor[i]} | G");
                vetor1[i] = 'G';
            }
            else
            {
                Console.WriteLine("Digite uma letra válida!!");
            }            

        }
        Console.Write("\n***FITA DE DNA***\nDNA DE BASE: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($" |{vetor[i]}|");
        }

        Console.Write("\nCOMPLEMENTAR:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($" |{vetor1[i]}|");
        }

        Console.ReadKey();
    }
    

}
