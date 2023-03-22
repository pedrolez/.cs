abstract class Estudios : IEstudios , IVisualiza
{
    public int EdadMinima { get; protected set; }
    public int Duracion { get; protected set; }
    public string Nombre { get; protected set; }

    public Estudios(in string Nombre, in int  Duracion, in int EdadMinima)
    {
        this.EdadMinima = EdadMinima;
        this.Nombre = Nombre;
        this.Duracion = Duracion;
    }
    public abstract void Visualiza();
    public abstract int MuestraEdad();

}