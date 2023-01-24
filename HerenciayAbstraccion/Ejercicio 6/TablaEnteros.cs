abstract class TablaEnteros 
{
    protected int[] tablaEnteros;

    //Constructor
    public TablaEnteros(int dimension) 
    {
        tablaEnteros = new int[dimension];
    }
    public virtual void Muestra() {
        for (int i = 0; i < tablaEnteros.Length; i++)
        {
            Console.Write(tablaEnteros[i]);
            Console.Write(", ");
        }
    }
    public string SumaPropia() {
       int positivos = 0, negativos = 0, sumP = 0, sumN = 0;

        for(int i = 0; i < tablaEnteros.Length; i++) 
        {
            if(tablaEnteros[i] < 0) 
            {
                negativos++;
                sumN += tablaEnteros[i];
            }
            else if(tablaEnteros[i] > 0) 
            {
                positivos++;
                sumP += tablaEnteros[i];
            }                
        }

        if(positivos > negativos)
        {
            return  $"Hay más números positivos, la suma de ellos es: {sumP};
        } 
        else 
        {
             return  $"Hay más números negativos, la suma de ellos es: {sumN};
        }
    }
    public abstract void GuardarNumerosEnTabla();
}