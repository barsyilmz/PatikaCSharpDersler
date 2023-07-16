using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle girin: ");
        string cumle = Console.ReadLine();

        List<char> sesliHarfler = new List<char>();

        foreach (char harf in cumle)
        {
            if (IsSesliHarf(harf))
            {
                if (!sesliHarfler.Contains(harf))
                {
                    sesliHarfler.Add(harf);
                }
            }
        }

        sesliHarfler.Sort();

        Console.WriteLine("Sesli Harfler:");
        foreach (char harf in sesliHarfler)
        {
            Console.Write(harf + " ");
        }
    }

    static bool IsSesliHarf(char harf)
    {
        harf = char.ToLower(harf);

        return harf == 'a' || harf == 'e' || harf == 'ı' || harf == 'i' || harf == 'o' || harf == 'ö' || harf == 'u' || harf == 'ü';
    }
}
