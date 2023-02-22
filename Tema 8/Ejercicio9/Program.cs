using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce la subcadena a buscar: ");
        string subcadena = Console.ReadLine();

       
        Console.Write("Introduce el nombre del fichero: ");
        string fichero = Console.ReadLine();

        
        if (!File.Exists(fichero))
        {
            Console.WriteLine($"El fichero {0} no existe. {fichero}");
        }

       

  
        using (StreamReader lector = new StreamReader(fichero))
        {
            int numeroLinea = 0;
            bool encontrado = false;

            while (lector.EndOfStream == false)
            {
                string linea = lector.ReadLine();
                numeroLinea++;

                MatchCollection coincidencias = regex.Matches(linea);

              
                if (coincidencias.Count > 0)
                {
                    encontrado = true;

                    Console.Write($"Línea {0}: \"{1}\". ", numeroLinea, linea);
                    Console.WriteLine($"Apariciones de la subcadena: {0}. {coincidencias.Count}");
                }
            }

         
            if (encontrado == false)
            {
                Console.WriteLine("CADENA NO ENCONTRADA");
            }
        }
    }
}

