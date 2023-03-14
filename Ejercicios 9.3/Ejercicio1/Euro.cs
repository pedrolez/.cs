class Euro
{
    public double Valor { get; set; }

    public Euro(in double Valor)
    {
        this.Valor = Valor;
    }

    public override string ToString()
    {
        return $"{Valor} euros";
    }

    public override bool Equals(object obj) => obj is Euro e && e.GetHashCode() == this.GetHashCode();
    public override int GetHashCode() => ToString().GetHashCode();
    public static bool operator ==(Euro e1, Euro e2) => e1.Equals(e2);
    public static bool operator !=(Euro e1, Euro e2) => e1.Equals(e2);



    //Suma
    public static Euro operator + (Euro e1, Euro e2)
    {
        double suma = e1.Valor + e2.Valor;
        return new Euro(suma);
    }

      public static Euro operator + (Euro e1, Peseta p1)
    {
        double suma = e1.Valor + p1.Valor * 0.0060;
        return new Euro(suma);
    }



    //Resta

     public static Euro operator - (Euro e1, Euro e2)
    {
        double resta = e1.Valor - e2.Valor;
        return new Euro(resta);
    }

      public static Euro operator - (Euro e1, Peseta p1)
    {
        double resta = e1.Valor - p1.Valor * 0.0060;
        return new Euro(resta);
    }


    

    
}