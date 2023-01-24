class Guerrero : Humano
{

    public enum Arma
    {
        ligera,
        pesada,
        corta,
        larga
    }

    private Arma arma;

    public enum Armadura
    {
        laminar,
        malla,
        placas
    }
private Armadura armadura;

public Guerrero(in Arma arma = Arma.ligera, in Armadura armadura = Armadura.malla, in string nombre = "NULL", in string sexo = "NULL", in int edad = 0, in int peso = 0, in int fuerza = 0, in int inteligencia = 0, in int destreza = 0, in int energia = 0) : base(nombre , sexo,edad, peso, fuerza, inteligencia, destreza, energia)
    {
    this.arma = arma;
    this.armadura = armadura;
}

public string ACadena()
{
    return $"Nombre: {nombre} \nEdad: {edad} años \nSexo: {sexo} \nPeso: {peso}Kg \nFuerza: {fuerza} \nInteligencia {inteligencia} \nDestreza: {destreza} \nArma: {this.arma} \nArmadura: {this.armadura}";
}



}