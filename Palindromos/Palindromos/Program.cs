using System;

class Program
{
    static void Main(string[] args)
    {
        string palabra, palabraInvertida = "";


        Console.WriteLine("Ingrese una palabra: ");
        palabra = Console.ReadLine();


        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palabraInvertida += palabra[i];
        }


        if (palabra.Equals(palabraInvertida))
        {
            Console.WriteLine("La palabra **{0}** es un palíndromo.", palabra);
        }
        else
        {
            Console.WriteLine("La palabra **{0}** no es un palíndromo.", palabra);
        }
    }
}