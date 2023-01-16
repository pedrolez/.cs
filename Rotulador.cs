class Rotulador
{

    public enum Color 
    {
     Verde = 1,
     Azul = 2,
     Rojo = 3, 
     Negro = 4
    }

    public Color color;

    public void Rotula (double perimetro)
    {
        Console.WriteLine("Se ha rotulado el perímetro");
    }
    
}