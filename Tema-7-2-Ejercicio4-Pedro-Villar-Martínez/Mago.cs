class Mago : Humano
{

    public enum LibroHechizos
    {
        oscuro,
        curacion,
        criaturas,
        encantamientos
    }

    private LibroHechizos libroHechizos;

    public enum Tunica
    {
        toga,
        terciopelo,
        batamanta,
        albornoz
    }
    private Tunica tunica;

    public Mago(in LibroHechizos libroHechizos = LibroHechizos.curacion, in Tunica tunica = Tunica.albornoz, in string nombre = "NULL", in string sexo = "NULL", in int edad = 0, in int peso = 0, in int fuerza = 0, in int inteligencia = 0, in int destreza = 0, in int energia = 0) : base( nombre,  sexo,  edad ,  peso ,  fuerza ,  inteligencia ,  destreza ,  energia )
    {
        this.libroHechizos = libroHechizos;
        this.tunica = tunica;
    }

    public string ACadena()
    {
        return $"Nombre: {nombre} \nEdad: {edad} años \nSexo: {sexo} \nPeso: {peso}Kg \nFuerza: {fuerza} \nInteligencia {inteligencia} \nDestreza: {destreza} \nLibro de hechizos: {this.libroHechizos} \nTúnica: {this.tunica}";
    }



}