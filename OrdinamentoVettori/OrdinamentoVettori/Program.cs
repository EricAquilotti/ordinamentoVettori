using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione e popolamento del vettore di interi
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

            //chiamo il metodo ordina
            ordina(vettore);

            //stampo il contenuto del vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //metodo per l'ordinamento
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
