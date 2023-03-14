class Peseta
{
    public double Valor { get; set; }

    public Peseta(in double Valor)
    {
        this.Valor = Valor;
    }

    public override string ToString()
    {
        return $"{Valor} pesetas";
    }

    public override bool Equals(object obj) => obj is Peseta p && p.GetHashCode() == this.GetHashCode();
    public override int GetHashCode() => ToString().GetHashCode();
    public static bool operator ==(Peseta p1, Peseta p2) => p1.Equals(p2);
    public static bool operator !=(Peseta p1, Peseta p2) => p1.Equals(p2);


     //Suma
    

      public static Peseta operator + (Peseta p1, Euro e1)
    {
        double suma = p1.Valor + e1.Valor * 166.3860;

        return new Peseta(suma);
    }

      public static Peseta operator + (Peseta p1, Peseta p2)
    {
        double suma = p1.Valor + p2.Valor;
        return new Peseta(suma);
    }


    //Resta


      public static Peseta operator - (Peseta p1, Euro e1)
    {
        double resta = p1.Valor - e1.Valor * 166.3860;
        return new Peseta(resta);
    }

      public static Peseta operator - (Peseta p1, Peseta p2)
    {
        double resta = p1.Valor - p2.Valor;
        return new Peseta(resta);
    }
}