using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            n = ask_n();
            int[] array1 = new int[n];
            int[] arrayPari = new int[n];
            int[] arrayDispari = new int[n];
            int nPari = 0, nDispari = 0;
            carica_vettore(array1);
            separa(array1, arrayDispari, arrayPari, ref nPari, ref nDispari);
            Array.Resize(ref arrayPari, nPari);
            Array.Resize(ref arrayDispari, nDispari);
            stampa(array1, "vettore iniziale");
            if (nPari == 0) 
            {
                Console.Write(" \nvettore pari vuoto");
            }
            else 
            { 
                stampa(arrayPari, "vettore pari");
            }
            if (nDispari == 0) 
            {
                Console.Write("\n vettore dispari vuoti ");
            }
            else
            {
                stampa(arrayDispari, "vettore dispari");
            }
        }

        private static void separa(int[] array, int[] AD, int[] AP, ref int nPari, ref int nDispari)
        {
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] %2 == 0)
                {
                    AP[nPari] =  array[i];
                    nPari++;
                }
                else
                {
                    AD[nDispari] = array[i];
                    nDispari++;
                }
            } 
        }

        private static void stampa(int[] vettore, string msg)
        {
            Console.WriteLine("\n"+ msg);
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.Write(vettore[i].ToString() + " ");
            }
        }

        private static void carica_vettore(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 101);
            }
        }



        private static int ask_n()
        {
            int dimansion = 0;
            do
            {
                Console.Write("\n inserisci il numero di numeri che vuoi gestire: ");
            }while(!int.TryParse(Console.ReadLine(), out dimansion) || dimansion<2);
            return dimansion;
        }
    }
}
