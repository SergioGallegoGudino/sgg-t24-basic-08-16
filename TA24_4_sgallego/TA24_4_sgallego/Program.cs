using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurant
{
    class Restaurant
    {

        public static void Main(string[] args)
        {
            //MILESTONE 1
            //FASE 1
            int billet5 = 5;
            int billet10 = 10;
            int billet20 = 20;
            int billet50 = 50;
            int billet100 = 100;
            int billet200 = 200;
            int billet500 = 500;

            int totalMenjar = 0;

            String[] menu = new String[10];
            int[] preu = new int[10];
            //FASE 2 / FASE 3 / FASE 4
            for (int i = 0; i < menu.Length; i++)
            {
                menu[i] = "plat" + i;
                preu[i] = i;
            }
            int continuar = 0;
            List<String>eleccio = new List<String>();
            while (continuar != 1)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine("Plat - {0} | Preu - {1}", menu[i], preu[i]);
                }
                try
                {
                    Console.WriteLine("Qué vols demanar? ");
                    string platDemanat = Console.ReadLine();
                    if (Array.IndexOf(menu, platDemanat) != -1)
                    {
                        eleccio.Add(platDemanat);
                        Console.WriteLine("Afegit. Alguna cosa més? (SI: 0 | NO: 1) ");
                        continuar = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("El producte {0} no existeix al menú", platDemanat);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Has intruduit caracters invalids, intenta-ho de nou");
                }
                catch (ArgumentException ax) {
                    Console.WriteLine("No has introduit un tipus valid, intenta-ho de nou");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("El plat no s'ha introduit correctament, intenta-ho de nou");
                }
            }
            for (int x = 0; x < eleccio.Count; x++)
            {
                for(int y = 0; y < menu.Length; y++)
                {
                    if (eleccio[x] == menu[y])
                    {
                        totalMenjar += preu[y];
                    }
                }
            }
            Console.WriteLine("El preu total será de {0}", totalMenjar);
            
        }
    }

}
