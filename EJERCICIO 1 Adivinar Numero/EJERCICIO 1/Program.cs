<<<<<<< HEAD
﻿using System;

namespace NumeroMayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor = int.MinValue, menor = int.MaxValue;

            Console.WriteLine("Ingrese números positivos (cuando acabe 0 para salir):");

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero > mayor)
                        mayor = numero;

                    if (numero < menor)
                        menor = numero;
                }
            } while (numero != 0);

            Console.WriteLine($"El número mayor ingresado fue: {mayor}");
            Console.WriteLine($"El número menor ingresado fue: {menor}");

            Console.ReadLine();
        }
    }
}
=======
﻿using System;

namespace NumeroMayorYMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor = int.MinValue, menor = int.MaxValue;

            Console.WriteLine("Ingrese números positivos (cuando acabe 0 para salir):");

            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    if (numero > mayor)
                        mayor = numero;

                    if (numero < menor)
                        menor = numero;
                }
            } while (numero != 0);

            Console.WriteLine($"El número mayor ingresado fue: {mayor}");
            Console.WriteLine($"El número menor ingresado fue: {menor}");

            Console.ReadLine();
        }
    }
}
>>>>>>> 4ca46e9575e3c893681ddb900669fd777abdae03
