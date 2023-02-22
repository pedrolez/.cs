using System;
using System.IO;

class Program {


    static Microprocesador[] LeerProcesadores() 
    {
        Console.WriteLine("Introduce el número de procesadores que quieres guardar:");
        int numProcesadores = int.Parse(Console.ReadLine());
        Microprocesador[] procesadores = new Microprocesador[numProcesadores];
        for (int i = 0; i < numProcesadores; i++) 
        {
            Console.WriteLine($"Introduce los datos del procesador {i + 1} (modelo;nucleos;frecuencia):");
            string datos = Console.ReadLine();
            procesadores[i] = Microprocesador.AMicroprocesador(datos);
        }

        return procesadores;
    }

    static void GuardarProcesadores(Microprocesador[] procesadores) 
    {
        StreamWriter fichero = new StreamWriter("microprocesadores.csv", true);
        for (int i = 0; i < procesadores.Length; i++) 
        {
            fichero.WriteLine(procesadores[i].ACSV());
        }
        fichero.Close();
    }



    static void MostrarProcesadores(Microprocesador[] procesadores) 
    {
        for (int i = 0; i < procesadores.Length; i++) 
        {
            Console.WriteLine($"Procesador {i + 1}:");
            Console.WriteLine(procesadores[i].ToString());
            Console.WriteLine();
        }
    }


    static void Main() 
    {
        Microprocesador[] procesadores = LeerProcesadores();
        GuardarProcesadores(procesadores);
        Microprocesador[] procesadores2 = LeerProcesadores();
        MostrarProcesadores(procesadores2);
    }

}


 

    

    
