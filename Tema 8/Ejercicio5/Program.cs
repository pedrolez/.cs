using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       
        string folderPath = @"C:\datos";
        string filePath = Path.Combine(folderPath, "datos.txt");

      
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            
            
            Console.WriteLine("Introduce caracteres para guardar en el fichero. Pulsa ESC para salir.");
            ConsoleKeyInfo key;
            do
            {
                
                key = Console.ReadKey();
                writer.Write(key.KeyChar);
            } while (key.Key != ConsoleKey.Escape);

            Console.WriteLine("\n  Se han guardado los caracteres en el fichero.");
        }
    }
}

