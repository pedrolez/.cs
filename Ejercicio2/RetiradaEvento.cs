public class RetiradaEvento 
{
    public string Dni { get; set; }
    public double Cantidad { get;  set; }

    public RetiradaEvento(string dni, double cantidad)
    {
        Dni = dni;
        Cantidad = cantidad;
    }
}