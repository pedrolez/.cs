public class Cajero
{
    public int NumeroCajero { get; private set; }
    public event EventHandler<RetiradaEvento> RetiradaDeEfectivo;

    public Cajero(int numeroCajero)
    {
        NumeroCajero = numeroCajero;
    }

    public void RetiraEfectivo(string dni, double cantidad)
    {
        Console.WriteLine("Realizando operación...");
        Console.WriteLine("Operación realizada con éxito");

        // Desencadenar el evento RetiradaDeEfectivo
        RetiradaDeEfectivo?.Invoke(this, new RetiradaEvento(dni, cantidad));
    }
}