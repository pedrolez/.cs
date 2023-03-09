class CuentaDeposito : CuentaAhorro
{
    private double recargo_tpu;
    public bool Vencimiento {get; set;}

   public CuentaDeposito(in string numero, in string titular, in double interes_tpu) : base (numero, titular, interes_tpu)
    {
        this.recargo_tpu = recargo_tpu;
    }

    public override void Reintegro(in double cantidad)
    {
        this.Saldo = this.Saldo - cantidad;

        /* debería hacer un if de si el depósito no venció pero no se como se hace
        cantidad = cantidad - (cantidad * recargo_tpu);*/
    }

    public override string ToString()
    {
        return base.ToString();
    }
}