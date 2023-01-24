class Humano
{
    protected string nombre, sexo;
    protected int edad, peso, fuerza, inteligencia, destreza, energia;

    public Humano(in string nombre = "NULL", in string sexo = "NULL", in int edad = 0, in int peso = 0, in int fuerza = 0, in int inteligencia = 0, in int destreza = 0, in int energia = 0)
    {
        this.nombre = nombre;
        this.sexo = sexo;
        this.edad = edad;
        this.peso = peso;
        this.fuerza = fuerza;
        this.inteligencia = inteligencia;
        this.destreza = destreza;
    }

    public string MostrarInformacion()
    {
        return $"Nombre: {nombre} \nEdad: {edad} años \nSexo: {sexo} \nPeso: {peso}Kg \nFuerza: {fuerza} \nInteligencia {inteligencia} \nDestreza: {destreza}";
    }
}