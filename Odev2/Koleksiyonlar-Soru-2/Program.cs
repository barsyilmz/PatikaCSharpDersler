using System;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[20];
        int[] enBuyukler = new int[3];
        int[] enKucukler = new int[3];

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Sayı {i+1}: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi))
            {
                sayilar[i] = sayi;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                i--;
            }
        }

        Array.Sort(sayilar);

        for (int i = 0; i < 3; i++)
        {
            enKucukler[i] = sayilar[i];
            enBuyukler[i] = sayilar[19 - i];
        }

        double enKucuklerOrtalama = CalculateAverage(enKucukler);
        double enBuyuklerOrtalama = CalculateAverage(enBuyukler);
        double ortalamaToplam = enKucuklerOrtalama + enBuyuklerOrtalama;

        Console.WriteLine("En Küçük 3 Sayılar:");
        PrintArray(enKucukler);

        Console.WriteLine("En Büyük 3 Sayılar:");
        PrintArray(enBuyukler);

        Console.WriteLine($"En Küçüklerin Ortalaması: {enKucuklerOrtalama}");
        Console.WriteLine($"En Büyüklerin Ortalaması: {enBuyuklerOrtalama}");
        Console.WriteLine($"Ortalama Toplamı: {ortalamaToplam}");
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
            return 0;

        double total = 0;
        foreach (var item in array)
        {
            total += item;
        }

        return total / array.Length;
    }
}
