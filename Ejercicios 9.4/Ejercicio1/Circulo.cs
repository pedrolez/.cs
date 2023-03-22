class Circulo : IFigura
{
    public int Radio { get; }
    

    public Circulo(in int Radio)
    {
        this.Radio = Radio;
    }

    public void Dibuja() => Console.WriteLine($"Círculo de radio {this.Radio} dibujado.");
    public float Area() => (float) (Math.PI * Math.Pow(Radio,2));
    public float Perimetro() => (float) (2 * Math.PI * Radio);
}