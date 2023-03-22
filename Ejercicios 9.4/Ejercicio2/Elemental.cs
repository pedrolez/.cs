class Elemental : Estudios
{
   
     public Elemental(in string Nombre, in int Duracion) : base(Nombre, Duracion, 12)
    {

    }

    public override int MuestraEdad() => 12;

    public override void Visualiza()
    {
        Console.WriteLine($"El grado Elemental de {Nombre}, tiene una duracion de {Duracion} horas.");
    }
}