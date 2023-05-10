using System;
using System.Threading;















class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto Cajero
        Cajero cajero = new Cajero(1);

        // Crear objetos EnvioEMail y EnvioSMS
        EnvioEMail envioEmail = new EnvioEMail();
        EnvioSMS envioSMS = new EnvioSMS();

        // Suscribir los objetos EnvioEMail y EnvioSMS al evento RetiradaDeEfectivo del objeto Cajero
        cajero.RetiradaDeEfectivo += envioEmail.EnviarAvisoRetiradaDeEfectivo;
        cajero.RetiradaDeEfectivo += envioSMS.EnviarAvisoRetiradaDeEfectivo;

        // Realizar una retirada de efectivo
        cajero.RetiraEfectivo("12345678A", 1000.0);
    }
}
