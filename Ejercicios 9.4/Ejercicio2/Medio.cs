class Medio : Estudios
{

  
    private string superior;

     public Medio(in string Nombre, in int Duracion, in string superior) :base(Nombre, Duracion, 16)
    {
        this.superior = superior;
       
    }

    public override int MuestraEdad() => EdadMinima;

    public override void Visualiza()
    {
        
        Console.WriteLine($"El grado Medio de {Nombre}, tiene una duracion de {Duracion} horas y te da acceso al grado superior de {superior}");
    }
}