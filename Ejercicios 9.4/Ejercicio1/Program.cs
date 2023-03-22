internal class Program
{
    private static void Main(string[] args)
    {
        Circulo ci = new Circulo(9);
        ci.Dibuja();
        Console.WriteLine($"Área: {ci.Area():f2}");
        Console.WriteLine($"Perímetro {ci.Perimetro():f2}");


        Rectangulo r = new Rectangulo(6,5);
        r.Dibuja();
        Console.WriteLine($"Área: {r.Area()}");
        Console.WriteLine($"Perímetro {r.Perimetro()}");


        Cuadrado cu = new Cuadrado(8);
        cu.Dibuja();
        Console.WriteLine($"Área: {cu.Area()}");
        Console.WriteLine($"Perímetro {cu.Perimetro()}");


    }
}