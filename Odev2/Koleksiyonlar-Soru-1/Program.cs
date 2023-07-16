using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        int adet = 0;

        while (adet < 20)
        {
            Console.Write("Pozitif bir sayı girin: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi) && sayi > 0)
            {
                if (IsAsal(sayi))
                    asalSayilar.Add(sayi);
                else
                    asalOlmayanSayilar.Add(sayi);

                adet++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir sayı girin.");
            }
        }

        Console.WriteLine("Asal Sayılar:");
        asalSayilar.Sort();
        asalSayilar.Reverse();
        PrintArrayList(asalSayilar);

        Console.WriteLine("Asal Olmayan Sayılar:");
        asalOlmayanSayilar.Sort();
        asalOlmayanSayilar.Reverse();
        PrintArrayList(asalOlmayanSayilar);

        Console.WriteLine($"Asal Sayılar - Eleman Sayısı: {asalSayilar.Count}, Ortalama: {CalculateAverage(asalSayilar)}");
        Console.WriteLine($"Asal Olmayan Sayılar - Eleman Sayısı: {asalOlmayanSayilar.Count}, Ortalama: {CalculateAverage(asalOlmayanSayilar)}");
    }

    static bool IsAsal(int sayi)
    {
        if (sayi < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static double CalculateAverage(ArrayList list)
    {
        if (list.Count == 0)
            return 0;

        double total = 0;
        foreach (var item in list)
        {
            total += (int)item;
        }

        return total / list.Count;
    }
}
