internal class Program
{

    public static Object LeeEnum(Type tipo, string texto, string textoError)
    {
        Object valorEnumLeido = null;
        bool entradaCorrecta;
        do
        {
            string entradaUsuario;

            Console.Write(texto);
            entradaUsuario = Console.ReadLine();
            entradaCorrecta = Enum.IsDefined(tipo, entradaUsuario);

            if (entradaCorrecta)
                valorEnumLeido = Enum.Parse(tipo, entradaUsuario);
            else
            {
                Console.WriteLine(textoError);
                string mensaje = "Los posibles valores son: "
                                 + string.Join(", ", Enum.GetNames(tipo));
                Console.WriteLine(mensaje);
            }
        }
        while (!entradaCorrecta);

        return valorEnumLeido;
    }

    private static void Main(string[] args)
    {
        Guerrero.Arma arma = (Guerrero.Arma)LeeEnum(typeof(Guerrero.Arma),
                                                   "Introduce el tipo de arma: ",
                                                   "El tipo de arma es erroneo");

        Guerrero.Armadura armadura = (Guerrero.Armadura)LeeEnum(typeof(Guerrero.Armadura),
                                                    "Introduce el tipo de armadura: ",
                                                    "El tipo de arma es erroneo");

        Guerrero guerrero = new Guerrero(arma, armadura, "Arturo", "Hombre", 70, 100, 60, 80, 65);

        Mago.LibroHechizos libroHechizos = (Mago.LibroHechizos)LeeEnum(typeof(Mago.LibroHechizos),
                                                    "Introduce el tipo de libro de hechizos: ",
                                                    "El tipo de arma es erroneo");

        Mago.Tunica tunica = (Mago.Tunica)LeeEnum(typeof(Mago.Tunica),
                                                    "Introduce el tipo de tunica: ",
                                                    "El tipo de arma es erroneo");

        Mago mago = new Mago(libroHechizos, tunica, "Merlin", "Hombre", 70, 40, 100, 90, 95);

        Console.WriteLine(guerrero.ACadena());
        Console.WriteLine(mago.ACadena());
    }
}