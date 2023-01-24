
class TablaPares : TablaEnteros {

    //Constructor
    public TablaPares(int tamaño):base(tamaño) {}
    public override void GuardarNumerosEnTabla() {
        int num;
        for (int i = 0; i < tablaEnteros.Length;)
        {
            Console.WriteLine("Escriba un número:  ");
            num=int.Parse(Console.ReadLine());

            if(num %2 == 0) 
            {
                tablaEnteros[i] = num;
                i++;
            }
        }
    }
}