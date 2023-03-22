internal class Program
{
    private static void Main(string[] args)
    {
        Elemental e = new Elemental("Jardinería", 400);
        Console.WriteLine(e.MuestraEdad());
        e.Visualiza();

        Medio m = new Medio("Jardinería", 400, "Técino superior de jardineria");
        Console.WriteLine(m.MuestraEdad());
        m.Visualiza();

        Superior s = new Superior("Técino superior de jardineria", 400, "Villena");
        Console.WriteLine(s.MuestraEdad());
        s.Visualiza();

    }
}