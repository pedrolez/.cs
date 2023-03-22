class Rectangulo : IFigura
{
    public int Base { get; }
    public int Altura { get; }

    public Rectangulo(in int Base, in int Altura)
    {
        this.Base = Base;
        this.Altura = Altura;
    }

    public void Dibuja() => Console.WriteLine($"Rectángulo de base {this.Base} y altura {this.Altura} dibujado.");
    public float Area() => Base * Altura;
    public float Perimetro() => (Base + Altura) * 2;
}