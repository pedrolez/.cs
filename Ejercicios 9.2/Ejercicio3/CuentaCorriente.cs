class CuentaCorriente : Cuenta
{
    private int maximoTransaccionesGratuitasPorMes;
    private double recargoXTransaccionAdicional_Euros;
    private int numeroTransaccionesMesActual;

    public CuentaCorriente(in string numero, in string titular, in int maximoTransaccionesGratuitasPorMes, in double recargoXTransaccionAdicional_Euros) : base(numero, titular)
    {
        this.maximoTransaccionesGratuitasPorMes = maximoTransaccionesGratuitasPorMes;
        this.recargoXTransaccionAdicional_Euros = recargoXTransaccionAdicional_Euros;
        numeroTransaccionesMesActual = 0;
    }

    private void reiniciaTransacciones()
    {
        //No estoy muy seguro de si el formato de DateTime es correcto
        if(DateTime.Now.ToString("dd") == "01")
        {
            numeroTransaccionesMesActual = 0;
        }
    }

    public override void Ingreso(in double cantidad)
    {
        base.Ingreso(cantidad);
    }

    public override void Reintegro(in double cantidad)
    {
        base.Reintegro(cantidad);
    }

    public void AplicaRecargosMes()
    {
         if(DateTime.Now.ToString("dd") == "01")
        {
            Saldo = Saldo - (numeroTransaccionesMesActual - maximoTransaccionesGratuitasPorMes) * recargoXTransaccionAdicional_Euros;
        }
    }

    public override string ToString()
    {
        return base.ToString();
    }

}