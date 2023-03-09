class CuentaAhorro : Cuenta
{
    private double interes_tpu;
    public CuentaAhorro(in string numero, in string titular, in double interes_tpu) : base (numero, titular)
    {
        this.interes_tpu = interes_tpu;
    }

    public void SumaInteres()
    {
        Saldo = Saldo + (Saldo *interes_tpu);
    }

    public override string ToString()
    {
        return $"... en Cuenta Ahorro \nNumero de cuenta: {Numero} \nTitular: {titular} \nSaldo: {Saldo} Euros";
    }

    
}