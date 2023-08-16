using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Variables
{

    class Repetides
    {

        public static void Main(string[] args)
        {
            //MILESTONE 1
            //FASE 1
            char[] nom = { 'S', 'E', 'R', 'G', 'I', 'O' };
            for (int i = 0; i < nom.Length; i++)
            {
                Console.WriteLine(nom[i]);
            }
            //FASE 2
            List<char> nom2 = new List<char>(nom);
            for (int i = 0; i < nom2.Count; i++)
            {
                if (nom2[i] == 'A' || nom2[i] == 'E' || nom2[i] == 'I' || nom2[i] == 'O' || nom2[i] == 'U')
                {
                    Console.WriteLine("VOCAL");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }
                Console.WriteLine(nom[i]);
            }
            //FASE 3
            List<char> nom3 = new List<char>(nom);
            Dictionary<char, int> contarLletres = new Dictionary<char, int>();
            foreach (char letra in nom3)
            {
                if (char.IsLetter(letra))
                {
                    if (contarLletres.ContainsKey(letra))
                    {
                        contarLletres[letra]++;
                    }
                    else
                    {
                        contarLletres[letra] = 1;
                    }
                }
            }

            foreach (var kvp in contarLletres)
            {
                Console.WriteLine( "Lletra {0} | Frecuencia {1}", kvp.Key, kvp.Value);
            }
            //FASE 4
            char[] cognom = { 'G', 'A', 'L', 'L', 'E', 'G', 'O' };
            List<char> cognom1 = new List<char>(cognom);
            List<char> fullname = new List<char>();

            fullname.AddRange(nom2);
            fullname.Add(' ');
            fullname.AddRange(cognom1);

            for (int i = 0; i < fullname.Count; i++)
            {
                Console.WriteLine(fullname[i]);
            }
            //MILESTONE 2
            int limit = 5;
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Introdueix la alçada maxima: ");
            int alcada = int.Parse(Console.ReadLine());
            for (int i = alcada; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //MILESTONE 3

            for (int hores = 0; hores < 24; hores++)
            {
                for (int minuts = 0; minuts <= 60; minuts++)
                {
                    for (int segons = 0; segons <= 60; segons++)
                    {
                        Console.Write($"\r");
                        if (hores < 10)
                        {
                            Console.Write("0");
                        }
                        Console.Write($"{hores}:");
                        if (minuts < 10)
                        {
                            Console.Write("0");
                        }
                        Console.Write($"{minuts}:");
                        if (segons < 10)
                        {
                            Console.Write("0");
                        }
                        Console.Write($"{segons}");
                        Thread.Sleep(1000);
                    }
                }
                if (hores == 23)
                {
                    hores = -1;
                }
            }

        }
    }

}
