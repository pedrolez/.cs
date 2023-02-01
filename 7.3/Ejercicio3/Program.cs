internal partial class Program
{

     static double CalculaLogaritmo(double numero)
        {
            if (numero <= 0)
                throw new ParametroNoValidoException("El número introducido no es válido. El logaritmo no está definido para números menores o iguales a 0.");
            return Math.Log10(numero);
        }
    private static void Main(string[] args)
    {
         try
            {
                if (args.Length == 0)
                    throw new ParametroNoValidoException("No se ha introducido ningún parámetro.");

                double numero = double.Parse(args[0]);
                Console.WriteLine("El logaritmo en base diez de " + numero + " es " + CalculaLogaritmo(numero));
            }
            catch (FormatException)
            {
                Console.WriteLine("El parámetro introducido no es un número.");
            }
            catch (ParametroNoValidoException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
