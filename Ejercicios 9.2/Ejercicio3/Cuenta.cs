 class Cuenta
    {
        protected NumeroCuenta Numero { get; }
        protected string titular; //En el UML está private pero necesito llamarlo desde los ToString de las clases hijas.
        public double Saldo { get; protected set; }


        public Cuenta(string numero, string titular)
        {
            this.Numero = new NumeroCuenta(numero);
            this.titular = titular;
            Saldo = 0;
        }

        public virtual void Ingreso(in double cantidad)
        {
            Saldo = Saldo + cantidad;
        }

        public virtual void Reintegro(in double cantidad)
        {
            if (Saldo - cantidad > 0)
                Saldo = Saldo - cantidad;
            else
                throw new SaldoInsuficienteException($"Saldo en cuenta {Numero} {Saldo:C} insuficiente para reintegro de {cantidad:C}.");
        }

        public override string ToString()
        {
            string texto = $"Numero de cuenta: {Numero}\n";
            texto += $"Titular: {titular}\n";
            texto += $"Saldo: {Saldo:C}";
            return texto;
        }
    }