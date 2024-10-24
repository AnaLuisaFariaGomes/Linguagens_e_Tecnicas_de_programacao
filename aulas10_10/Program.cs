using System;
using Arrays;

class Program
{  
    static void Main()
    {
        double[] meuvetor = new double[5]; //declarnado o vetor
        Console.WriteLine("***Vetores em C#***");
        Console.WriteLine("Digite os valores do vetor: ");
       
        //gerando dados para o vetor
        BibliotecaArray.geravetor(meuvetor);
        
        //mostrar dados do vetor
        Console.WriteLine("***Vetor recebido***");
        BibliotecaArray.mostravetor(meuvetor);

        //lendo dados para o vetor
        BibliotecaArray.leiavetor(meuvetor);
        //mostrar dados do vetor
        Console.WriteLine("***Vetor recebido***");
        BibliotecaArray.mostravetor(meuvetor);

        Console.ReadKey();
    }
}