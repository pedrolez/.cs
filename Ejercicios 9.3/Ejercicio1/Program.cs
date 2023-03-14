internal class Program
{
    private static void Main(string[] args)
    {
        Euro e = new Euro(4);
        Peseta p = new Peseta(1000);

        Euro s = e + p;
        Console.WriteLine(s);

        Peseta r = p - e;
        Console.WriteLine(r);

        Peseta p2 = new Peseta(1001);

      
        if (p != p2)
        {
            Console.WriteLine("Son diferentes");
        }
        


        p2.Valor = 1000;

        if (p == p2)
        {
            Console.WriteLine("Son iguales");
        }




    }
}
