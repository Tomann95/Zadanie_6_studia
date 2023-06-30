﻿using System;
using Internal;

class Program
{
    static void Main()
    {
        double x1 = 1.0;
        double y1 = 2.0;
        double x2 = 4.0;
        double y2 = 6.0;

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);
        Console.WriteLine("Długość odcinka: " + dlugoscOdcinka);
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}

