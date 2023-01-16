class Empleado
{
    private readonly string dni, nombre;
    private readonly int añoNacimiento;
    private const int SALARIO_BASE = 1200;
    public enum Categoria
    {
        Subalterno = 10,
        Administrativo = 20,
        JefeDepartamento = 40,
        Gerente = 60
    }

    public Categoria categoria;

    //constructor
    public Empleado(in string dni, in string nombre, in int añoNacimiento)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.añoNacimiento = añoNacimiento;
    }

    //constructor de copia
    public Empleado(in Empleado e)
    {
        this.categoria = e.categoria;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public int GetAñoNacimiento()
    {
        return this.añoNacimiento;
    }

    public string GetDni()
    {
        return this.dni;
    }

    public void SetCategoria(in Categoria categoria)
    {
        this.categoria = categoria;
    }

    public double Salario()
    {
        return SALARIO_BASE + (SALARIO_BASE * (double)this.categoria / 100);
    }

    public string ACadena()
    {
        return $"El empleado {this.nombre} con DNI {this.dni} y año de nacimiento {this.añoNacimiento}. Tiene un salario de {Salario()} euros debido a que es {categoria}";
    }

}