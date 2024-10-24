using System;
using Arrays;
class Exercicio11
{
    static void Main ()
    {
        string frase;

        Console.WriteLine("Digite a frase codificada: ");
        frase = Console.ReadLine().ToLower();

        for (int i = 1; i < frase.Length; i++)
        {
            if (frase[i] !='p')
            {
                Console.WriteLine(frase[i]);
            }
            else if (frase[i - 1]== 'p' && frase[i + 1] == 'p')
            {
                Console.WriteLine(frase[i]);
            }

        }

        Console.ReadKey();
    }
}
