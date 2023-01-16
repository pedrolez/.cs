class Circulo
{
    float radio;

    public Circulo (in float radio)
    {
        this.radio = radio;
    }

    public double Area(float radio)
    {
        return 3.14 * radio * radio;
    }

    public double Perimetro (float radio)
    {
        return 2 * 3.14 * radio;
    }
}