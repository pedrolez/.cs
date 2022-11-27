internal class Program
{
    private static void Main(string[] args)
    {

        //Ejercicio 6

        /*
        int numMayor = default; /* Tienes que rellenar el array aleatorio. Modulariza este ejercicio*/
        int posicion = default;

        int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};

        for(int i = 0; i < array.Length; i++){

            if(i == 0){
                numMayor = array[0];
                posicion = i+1;
            }

            if(array[i]>0){
                numMayor = array[i];
                posicion = i + 1;
            }


        }

        Console.WriteLine($"El número mayor es el {numMayor} y se encuentra en la posición {posicion}");
        */

        // Ejercicio 8

        /*
           Console.WriteLine("Dime un número y te digo si es capicua");
           char[] numero = Console.ReadLine().ToCharArray();
           char[] numeroInvertido = new char[numero.Length];
           int contador = 0;

           for (int i = numero.Length -1; i >= 0; i--){
               numeroInvertido[contador] = numero[i];
               contador ++;
           }
           bool igual = true;
           for(int i = 0; i < numero.Length; i ++){
               if(numero[i] != numeroInvertido[i]) igual = false;
           }

           if(igual){
               Console.WriteLine("Es capicua");
           }

           else{
               Console.WriteLine("No es capicua"); 
           }

           */

        //Ejercicio 10 /*Consulta este ejercicio que tiene una solución mucho más simple*/

        /*
        int[] resultados = new int[25];
        int[] frecuencia = new int[11];
        int[] notas = new int [11];

        for (int i = 0; i < 11; i++){
            notas[i] = i;
        }
        
        int j = default;
        
        while (j>= 0 || j <=10){

        for ( j = 0; j <= 24; j++){


            Console.WriteLine("Introduce una nota:");
            resultados[j] = int.Parse(Console.ReadLine());

            switch (resultados[j]){

                case 0:
                    frecuencia[0] = frecuencia[0] +1;
                break;

                case 1:
                    frecuencia[1] = frecuencia[1] + 1;
                    break;

                case 2:
                    frecuencia[2] = frecuencia[2] + 1;
                    break;

                case 3:
                    frecuencia[3] = frecuencia[3] + 1;
                    break;

                case 4:
                    frecuencia[4] = frecuencia[4] + 1;
                    break;

                case 5:
                    frecuencia[5] = frecuencia[5] + 1;
                    break;

                case 6:
                    frecuencia[6] = frecuencia[6] + 1;
                    break;

                case 7:
                    frecuencia[7] = frecuencia[7] + 1;
                    break;

                case 8:
                    frecuencia[8] = frecuencia[8] + 1;
                    break;

                case 9:
                    frecuencia[9] = frecuencia[9] + 1;
                    break;

                case 10:
                    frecuencia[10] = frecuencia[10] + 1;
                    break;

            }

         }

        }


        foreach (int c in notas)
        {
            Console.Write($"  {c,-4}");
        }
        
            Console.WriteLine("\n");

        foreach (int c in frecuencia)
        {
            Console.Write($"[ {c} ] ");
        }

    */

    }
}
