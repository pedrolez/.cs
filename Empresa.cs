class Empresa:Empleado2
{
    private readonly string cif, razonSocial;
    private string direccion;

     public Empresa(in string cidf, in string razonSocial, in string direccion, in string dni, in string nombre, in int añoNacimiento)
    {
        Empleado2.dni = dni;
        this.nombre = nombre;
        this.añoNacimiento = añoNacimiento;
    }
}