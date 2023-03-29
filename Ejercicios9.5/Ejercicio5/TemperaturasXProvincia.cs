
public class TemperaturasXProvincia 
{
    public string Provincia { get; }
    public float TemperaturaMaxima { get; }
    public float TemperaturaMinima { get; }
    public TemperaturasXProvincia(string provincia, float temperaturaMaxima, float temperaturaMinima)
    {
        Provincia = provincia;
        TemperaturaMaxima = temperaturaMaxima;
        TemperaturaMinima = temperaturaMinima;
    }


    public override string ToString()
    {
        return $"Nombre: {Provincia} \nTemperatura Máxima: {TemperaturaMaxima} \nTemperatura Mínima: {TemperaturaMinima}";
    }
    
}