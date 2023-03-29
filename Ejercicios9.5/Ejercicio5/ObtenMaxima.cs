public class ObtenMaxima : IObtenTemperatura
{
    public float ObtenTemperatura(TemperaturasXProvincia provincia)
    {
        return provincia.TemperaturaMaxima;
    }
}