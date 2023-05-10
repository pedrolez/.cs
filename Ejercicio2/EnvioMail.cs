public class EnvioEMail
{
    public void EnviarAvisoRetiradaDeEfectivo(object sender, RetiradaEvento e)
    {
        Console.WriteLine($"Buscando datos usuario {e.Dni}...");
        Console.WriteLine($"Enviando e-mail al usuario {e.Dni} de retirada de {e.Cantidad} el día {DateTime.Now.ToShortDateString()} a las {DateTime.Now.ToShortTimeString()} horas.");
    }
}