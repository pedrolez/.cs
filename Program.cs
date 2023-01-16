internal class Program
{

    
    private static void Main(string[] args)
    {

        /*Ejercicio 1
        Empleado e = new Empleado("12345678A", "Pepe", 2000);
        e.SetCategoria(Empleado.Categoria.Subalterno);
        Console.WriteLine(e.ACadena());
        */


        //Ejercicio 4    
        Compas compas = new Compas();
        Circulo circulo = compas.DibujaCirculo(3.5f);
        Rotulador rotulador = Estuche.GetRotuladores()
                              [
                                  new Random().Next(0, Estuche.NUMERO_ROTULADORES)
                              ];
        rotulador.Rotula(circulo.Perimetro());
        Pincel pincel = new Pincel();
        pincel.SetColor(Color.Verde);
        pincel.Pinta(circulo.Area());
        

    }

    
    }