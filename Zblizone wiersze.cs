using System;
using Internal;

class Program
{
    static void Main()
    {
        int[,] tablica = {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 3, 4, 2, 1 },
            { 2, 1, 3, 4 }
        };

        int[] najblizszeWiersze = ZnajdzNajblizszeWiersze(tablica);
        Console.WriteLine("Najbliższe wiersze: " + najblizszeWiersze[0] + ", " + najblizszeWiersze[1]);
    }

    static int[] ZnajdzNajblizszeWiersze(int[,] tablica)
    {
        int liczbaWierszy = tablica.GetLength(0);
        int minRoznica = int.MaxValue;
        int[] najblizszeWiersze = new int[2];

        for (int i = 0; i < liczbaWierszy; i++)
        {
            for (int j = i + 1; j < liczbaWierszy; j++)
            {
                int roznica = 0;

                for (int k = 0; k < tablica.GetLength(1); k++)
                {
                    int element1 = tablica[i, k];
                    int element2 = tablica[j, k];
                    roznica += (element1 - element2) * (element1 - element2);
                }

                if (roznica < minRoznica)
                {
                    minRoznica = roznica;
                    najblizszeWiersze[0] = i;
                    najblizszeWiersze[1] = j;
                }
            }
        }

        return najblizszeWiersze;
    }
}
