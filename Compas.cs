class Compas
{

    public Circulo DibujaCirculo(float radio)
    {
        Circulo circulo = new Circulo(radio);
        Console.WriteLine($"Dibujado un círculod de radio {radio}");
        return circulo;
    }

}