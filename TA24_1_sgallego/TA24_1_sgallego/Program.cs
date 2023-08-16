using System;
using System.ComponentModel.DataAnnotations;

namespace Variables
{

    class Variable
    {
        const int traspas = 1948;

        public static void Main(string[] args)
        {
            //MILESTONE 1
            //FASE 1
            String nom = "Sergio";
            String cognom1 = "Gallego";
            String cognom2 = "Gudiño";

            int dia = 26;
            int mes = 7;
            int any = 2002;

            Console.WriteLine("{0} {1} {2}", cognom1, cognom2, nom);
            Console.WriteLine("{0},{1},{2}", dia, mes, any);
            //FASE 2
            int interval = 4;
            int cantidadTraspaso = (any - traspas) / interval;
            Console.WriteLine(cantidadTraspaso);
            //FASE 3
            String fCerta = "Es un any de traspas";
            String fFalsa = "No es un any de traspas";
            for (int i = traspas; i <= any; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Boolean esTraspas = (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0);
            if (esTraspas)
            {
                Console.WriteLine(fCerta);
            }
            else
            {
                Console.WriteLine(fFalsa);
            }
            //FASE 4
            String introduccio = "El meu nom es " + nom + " " + cognom1 + " " + cognom2;
            String dataNaixement = "Vaig neixer el dia " + dia + "/" + mes + "/" + any;
            Console.WriteLine(introduccio);
            Console.WriteLine(dataNaixement);
            if (esTraspas)
            {
                Console.WriteLine("El meu any es de traspas");
            }
            else
            {
                Console.WriteLine("El meu any no es de traspas");
            }
            //MILESTONE 2
            double valor = 1.4567;
            int num1 = (int)valor;
            float num2 = (float)valor;
            decimal num3 = (decimal)valor;

            Console.WriteLine(valor);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            //MILESTONE 3
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int aux = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }
            array[array.Length-1] = aux;
        }
    }

}