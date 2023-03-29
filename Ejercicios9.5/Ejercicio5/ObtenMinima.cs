public class ObtenMinima : IObtenTemperatura
{
    public float ObtenTemperatura(TemperaturasXProvincia provincia)
    {
        return provincia.TemperaturaMinima;
    }
}