internal class Program
{

     static double CalculaLogaritmo(double num)
    {
        return Math.Log10(num);
    }
    private static void Main(string[] args)
    {
    
        try
        {
            if (args.Length == 0)
                throw new Exception("No se ha introducido ningún argumento");
            double num = Convert.ToDouble(args[0]);
            Console.WriteLine($"El logaritmo en base diez de {num} es {CalculaLogaritmo(num)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Número no válido");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
