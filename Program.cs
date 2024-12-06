using System;

class Program
{
    static void Main(string[] args)
    {
        Osoba osoba = new Osoba();

        Console.WriteLine("Podaj swój wzrost w metrach (np. 1.75):");
        osoba.Wzrost = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj swoją wagę w kilogramach (np. 70.50):");
        osoba.Waga = Convert.ToDouble(Console.ReadLine());
        double bmi = osoba.ObliczBMI();
        Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");
        Console.WriteLine($"Kategoria: {osoba.KategoriaBMI()}");

        Console.ReadKey();
    }
}
