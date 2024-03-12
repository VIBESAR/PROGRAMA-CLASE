using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce una frase: ");
        string frase = Console.ReadLine();

        int numeroPalabras = 0;
        bool enPalabra = false;
        for (int i = 0; i < frase.Length; i++)
        {
            if (char.IsWhiteSpace(frase[i]))
            {
                enPalabra = false;
            }
            else if (!enPalabra)
            {
                enPalabra = true;
                numeroPalabras++;
            }
        }

        int numeroVocales = 0;
        for (int i = 0; i < frase.Length; i++)
        {
            char letra = char.ToLower(frase[i]);
            if ("aeiouáéíóú".Contains(letra))
            {
                numeroVocales++;
            }
        }

        Console.WriteLine("Número de palabras: {0}", numeroPalabras);
        Console.WriteLine("Número de vocales: {0}", numeroVocales);
    }

}