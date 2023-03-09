class CuentaCredito : Cuenta
{
    private double interes_tpu;
    private double creditoMaximo_Euros;
    public double cargo;

    public CuentaCredito (in string numero, in string titular, in double interes_tpu, in double creditoMaximo_Euros) : base(numero, titular)
    {
        this.interes_tpu = interes_tpu;
        this.creditoMaximo_Euros = creditoMaximo_Euros;
        this.cargo = (Saldo < 0) ? Math.Abs(Saldo) * interes_tpu : 0d;
        Saldo = Saldo - cargo;
    }

    public override void Reintegro(in double cantidad)
    {
        base.Reintegro(cantidad);
    }

    public double CargaInteresesMes()
    {
        return 0;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}