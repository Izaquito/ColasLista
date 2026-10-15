using System;
using System.Collections.Generic;

namespace ColasLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colas colas = new Colas();

            colas.Agregar("A");
            colas.Agregar("B");
            colas.Agregar("C");

            Console.WriteLine(colas.ObtenerDatos());

            colas.Agregar("D");
            Console.WriteLine(colas.ObtenerDatos());

            colas.Eliminar();
            Console.WriteLine(colas.ObtenerDatos());

            colas.Eliminar();
            Console.WriteLine(colas.ObtenerDatos());
        }
    }
}
