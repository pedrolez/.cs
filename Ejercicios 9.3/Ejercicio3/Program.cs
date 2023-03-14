internal class Program
{
    private static void Main(string[] args)
    {
        NumeroCurioso n1 = new NumeroCurioso(1, 0, 0);
        NumeroCurioso n2 = new NumeroCurioso(0, 1, 0);

        Console.WriteLine(n1 + n2);
        Console.WriteLine(n1 - n2);
    }
}
