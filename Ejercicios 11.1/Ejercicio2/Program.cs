internal class Program
{

    public delegate void Infinitvo();

    static void Ser()
    {
        Console.WriteLine("To be");
    }

    static void Correr()
    {
        Console.WriteLine("Run");
    }

    static void Ver()
    {
        Console.WriteLine("See");
    }

    static void Pensar()
    {
        Console.WriteLine("Think");
    }

      static void Comer()
    {
        Console.WriteLine("Eat");
    }
    private static void Main(string[] args)
    {
        Infinitvo inf = null;

        inf += Ser;
        inf += Correr;
        inf += Ver;
        inf();

        inf -= Ser;
        inf -= Ver;
        inf += Pensar;
        inf += Comer;
        inf();

    }
}
