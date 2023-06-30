using System;
using Internal;

class Program
{
    static void Main()
    {
        int czas = 332;
        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine(sformatowanyCzas);
    }

    static string FormatujCzas(int czas)
    {
        TimeSpan ts = TimeSpan.FromSeconds(czas);
        string sformatowanyCzas = ts.ToString(@"hh\:mm\:ss");
        return sformatowanyCzas;
    }
}

