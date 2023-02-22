using System.Text;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        string path = default;
        FileStream f = null;
        byte[] datos;

        Console.WriteLine("Dame una ruta:");
        path = Console.ReadLine();

        f = new FileStream(path, FileMode.Create, FileAccess.Write);
        datos = Encoding.UTF8.GetBytes("Hola");
        f.Write(datos, 0, datos.Length);
    }
}