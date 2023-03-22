class Cuadrado : IFigura
{

    public int Lado { get; }

    public Cuadrado(in int Lado)
    {
        this.Lado = Lado;
    }
    public void Dibuja() => Console.WriteLine($"Cuadrado de lado {this.Lado} dibujado.");
    public float Area() => (float) Math.Pow(Lado, 2);
    public float Perimetro() => Lado * 4;
}