public class Osoba
{
    public double Wzrost { get; set; }
    public double Waga { get; set; }

    public double ObliczBMI()
    {
        return Waga / (Wzrost * Wzrost);
    }

    public string KategoriaBMI()
    {
        double bmi = ObliczBMI();
        if (bmi < 18.5)
            return "Niedowaga";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Waga prawidłowa";
        else if (bmi >= 25 && bmi < 29.9)
            return "Nadwaga";
        else
            return "Otyłość";
    }
}
