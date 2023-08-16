using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ciudad
{
    class Ciudad
    {
        
        public static void Main(string[] args)
        {
            static void delletrejar(String[] array, String ciutat)
            {
                char[] ciutatChar = ciutat.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = ciutatChar[i].ToString();
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    Console.Write(array[i]);
                }
                Console.WriteLine();
            }

            //MILESTONE 1
            //FASE 1

            Console.WriteLine("Introduce el nombre de la ciudad 1: ");
            String c1 = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la ciudad 2: ");
            String c2 = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la ciudad 3: ");
            String c3 = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la ciudad 4: ");
            String c4 = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la ciudad 5: ");
            String c5 = Console.ReadLine();
            Console.WriteLine("Introduce el nombre de la ciudad 6: ");
            String c6 = Console.ReadLine();

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", c1, c2, c3, c4, c5, c6);

            //FASE 2

            String[] ciutats = new string[] { c1, c2, c3, c4, c5, c6 };

            Array.Sort(ciutats);

            for (int i = 0; i < ciutats.Length; i++)
            {
                Console.WriteLine(ciutats[i]);
            }

            //FASE 3

            String[] ciutats4 = new string[6];
            Console.WriteLine("Reemplacem...");
            for (int i = 0; i < ciutats4.Length; i++) {
                ciutats4[i] = ciutats[i].Replace('a', '4'); ;
            }
            Array.Sort(ciutats4);
            for (int i = 0; i < ciutats4.Length; i++)
            {
                Console.WriteLine(ciutats4[i]);
            }

            //FASE 4

            String[] barcelona = new String[c1.Length];
            String[] madrid = new String[c2.Length];
            String[] valencia = new String[c3.Length];
            String[] malaga = new String[c4.Length];
            String[] cadis = new String[c5.Length];
            String[] santander = new String[c6.Length];

            delletrejar(barcelona, c1);
            delletrejar(madrid, c2);
            delletrejar(valencia, c3);
            delletrejar(malaga, c4);
            delletrejar(cadis, c5);
            delletrejar(santander, c6);

            //MILESTONE 2
            //FASE 1

            int[,] notes = new int[5,3];
            for (int x = 0;x < 5;x++)
            {
                double mitjana = 0;
                Console.WriteLine("Alumno " + (x+1));
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine("Introdueix la nota de la unitat " + (y+1));
                    int nota = int.Parse(Console.ReadLine());
                    if (nota < 0 && nota > 10)
                    {
                        notes[x, y] = 0;
                    }
                    else
                    {
                        notes[x, y] = nota;
                    }
                    mitjana += notes[x, y];
                }
                if ((mitjana/3)<5)
                {
                    Console.WriteLine("L'alumne ha suspes");
                }
                else
                {
                    Console.WriteLine("L'alumne ha aprobat");
                }
            }

            //MILESTONE 3

            static void nombreFibonacci(int posicio, int limit)
            {
                if (posicio <= 1)
                {
                    Console.Write(posicio + " | ");
                }
                else
                {

                    int anterior = 0;
                    int fibonacci = 1;
                    int resultat = 0;

                    for (int i = 2; i <= posicio; i++)
                    {
                        resultat = anterior + fibonacci;
                        anterior = fibonacci;
                        fibonacci = resultat;
                    }
                    if (resultat <= limit && resultat > 0)
                    {
                        Console.Write(resultat + " | ");
                    }   
                }
            }

            Console.WriteLine("Introdueix un numero: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                nombreFibonacci(i, num);
            }
        }
    }

}
