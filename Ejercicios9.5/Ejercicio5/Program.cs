internal class Program
{
    public static TemperaturasXProvincia[] RecogeTemperaturasPorProvincia()
    {
        Console.Write("De cuantas provincias quieres recoger la temperatura: ");
        var temperaturasPorProvincia = new TemperaturasXProvincia[int.Parse(Console.ReadLine())];
        Random seed = new Random();
        for (int i = 0; i < temperaturasPorProvincia.Length; i++)
        {
            Console.Write($"Introduce la provincia nº{i + 1}:  ");
            string provincia = Console.ReadLine();
            float temperaturaMaxima = seed.Next(17, 25);
            float temperaturaMinima = seed.Next(-5, 17);
            temperaturasPorProvincia[i] = new TemperaturasXProvincia(provincia, temperaturaMaxima, temperaturaMinima);
        }
        return temperaturasPorProvincia;
    }

    public static float CalcularMediaTemperaturas(TemperaturasXProvincia[] temperaturasXProvincia, IObtenTemperatura obtenTemperatura)
    {
        float media=0.0f;

        for(int i=0; i < temperaturasXProvincia.Length; i++)
        {
            media += obtenTemperatura.ObtenTemperatura(temperaturasXProvincia[i]);
         Console.WriteLine(obtenTemperatura.ObtenTemperatura(temperaturasXProvincia[i]));
        }

        return media / temperaturasXProvincia.Length;
    }

    public static void MuestraProvincias(TemperaturasXProvincia[] temperaturasXProvincia, float mediaTemperaturas, IObtenTemperatura obtenTemperatura, ICumplePredicado<float> cumplePredicado, string mensaje)
    {
        for(int i = 0; i < temperaturasXProvincia.Length; i++)
        {
            if(cumplePredicado.Predicado(obtenTemperatura.ObtenTemperatura(temperaturasXProvincia[i]), mediaTemperaturas))
            {
                Console.WriteLine(mensaje+ "\n" + temperaturasXProvincia[i]+ "\n");
            }
        }
    }
    private static void Main(string[] args)
    {
        TemperaturasXProvincia[] temperaturasXProvincia = RecogeTemperaturasPorProvincia();
        float mediaMaximas = CalcularMediaTemperaturas(temperaturasXProvincia, new ObtenMaxima());
        float mediaMinimas = CalcularMediaTemperaturas(temperaturasXProvincia, new ObtenMinima());
        Console.WriteLine("Media Minimas: " + mediaMinimas);
        Console.WriteLine("Media Máximas: " + mediaMaximas);
        MuestraProvincias(temperaturasXProvincia, mediaMaximas, new ObtenMaxima(), new MayorQue(), "Provincia con una máxima mayor que la media de las maxímas");
        MuestraProvincias(temperaturasXProvincia, mediaMinimas, new ObtenMinima(), new MenorQue(), "Provincia con una mínima menor que la media de las mínimas");
        MuestraProvincias(temperaturasXProvincia, mediaMinimas, new ObtenMinima(), new IgualQue(), "Provincia con una mínimas igual que la media de las mínimas");
    }

}