class Cuenta
{
    private string titular;
    private double saldo;
    private string numero;
    private NumeroCuenta c;

    public Cuenta(in string numero, in string titular, in double saldo = 0)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = saldo;
        this.c = new NumeroCuenta(numero);
    }

    public void Ingreso (in double cantidad)
    {
        saldo += cantidad;
    }

    public void Reintegro (in double cantidad)
    {
        if (saldo >= cantidad)
        {
            saldo -= cantidad;
        }

        else
        {
            throw new SaldoInsuficienteException("El reintegro no puede ser superior al saldo de la cuenta");
        }
    }

    public override string ToString()
    {
        return $"Titular de la cuenta: {titular} \nNúmero de la cuenta : {numero} \nSaldo: {saldo} mangos.";
    }
}