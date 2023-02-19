internal class Program
{
    /*Ejercicio 1
    enum Colores : int

    {

        Rojo = 0xFF0000,
        Azul = 0x0000FF,
        Amarillo = 0xFFFF00,
        Violeta = 0xC71585,
        Blanco = 0xFFFFFF,
        Negro = 0x000000,
        Gris = 0xCDCDCD,
        Marron = 0xA52A2A

    }


    */

    [Flags]
    public enum color : byte /*El nombre de los enumerados en mayúsculas*/

    {
        None = 0b_0000_0000,
        Rojo = 0b_0000_0001,
        Azul = 0b_0000_0010,
        Amarillo = 0b_0000_0100,
        Violeta = 0b_0000_1000,
        Blanco = 0b_0001_0000,
        Negro = 0b_0010_0000,
        Gris =  0b_0100_0000,
        Marron = 0b_1000_0000

    }

    static string MostrarMenu()
    {
        return "1. Mostrar colores \n2. Añadir color \n3. Eliminar color \n4. Salir";
    }

    static (string, int) EligeOpcion()
    {
        return ("Elige Opción", int.Parse(Console.ReadLine()));
    }

    static void MostrarColores()
    {
        color[] colores = (color[])Enum.GetValues(typeof(color));

        for(int i=0; i<= colores.Length; i++ )
        {
            Console.WriteLine(colores[i]);
        }
        
    }

    static void AñadirColor()
    {

        Console.WriteLine("Dime que color quieres añadir");
        string colorUsuario = Console.ReadLine();
        color extra = default;
        extras |= color.colorUsuario;

    }

    static void EliminarColor()
    {
        Console.WriteLine("Dime que color quieres eliminar");
        string colorUsuario = Console.ReadLine();
        color extra = default;
        extras &= ~color.colorUsuario;
    }

    private static void Main(string[] args)
    {
      
        Console.WriteLine(MostrarMenu());
        
        int opcionUsuario = Console.WriteLine(EligeOpcion());

        switch (opcionUsuario)
        {
            case 1:
            MostrarColores();
            break;

            case 2:
            AñadirColor();
            break;

            case 3:
            EliminarColor();
            break;

            case 4:
            break;
        }



    }



}
