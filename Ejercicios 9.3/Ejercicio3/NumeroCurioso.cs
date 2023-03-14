class NumeroCurioso
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public NumeroCurioso (in double A, in double B, in double C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public static NumeroCurioso operator + (NumeroCurioso n1, NumeroCurioso n2)
    {
        
        double a = (n1.A + n2.A)/ Math.Sqrt((Math.Pow(n1.B + n2.B,2)) + (Math.Pow(n1.C + n2.C,2)) + (Math.Pow(n1.A + n2.A,2)));
        double b = (n1.B + n2.B)/ Math.Sqrt((Math.Pow(n1.B + n2.B,2)) + (Math.Pow(n1.C + n2.C,2)) + (Math.Pow(n1.A + n2.A,2)));;
        double c = (n1.C + n2.C)/ Math.Sqrt((Math.Pow(n1.B + n2.B,2)) + (Math.Pow(n1.C + n2.C,2)) + (Math.Pow(n1.A + n2.A,2)));;

        return new NumeroCurioso(a,b,c);
    }


    public static NumeroCurioso operator - (NumeroCurioso n1, NumeroCurioso n2)
    {
        
        double a = (n1.A - n2.A)/ Math.Sqrt((Math.Pow(n1.B - n2.B,2)) + (Math.Pow(n1.C - n2.C,2)) + (Math.Pow(n1.A - n2.A,2)));
        double b = (n1.B - n2.B)/ Math.Sqrt((Math.Pow(n1.B - n2.B,2)) + (Math.Pow(n1.C - n2.C,2)) + (Math.Pow(n1.A - n2.A,2)));;
        double c = (n1.C - n2.C)/ Math.Sqrt((Math.Pow(n1.B - n2.B,2)) + (Math.Pow(n1.C - n2.C,2)) + (Math.Pow(n1.A - n2.A,2)));;

        return new NumeroCurioso(a,b,c);
    }


    public override string ToString()
    {
        return ($"La operacion entre los número curiosos es ({this.A:f2};{this.B:f2};{this.C:f2}) ");
    }

}