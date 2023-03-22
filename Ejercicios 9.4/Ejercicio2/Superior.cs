class Superior : Estudios
{

      private string lugar;
  public Superior(in string Nombre, in int Duracion, in string lugar) :base(Nombre, Duracion,18)
    {
        this.lugar = lugar;
    }

    public override int MuestraEdad() => EdadMinima;

     public override void Visualiza()
    {
        Console.WriteLine($"El grado Superior de {Nombre}, tiene una duracion de {Duracion} horas y se realiza en {lugar}");
    }


}