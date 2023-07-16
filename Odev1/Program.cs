//SORU 1 
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Giriş yapmak istediğiniz adedi giriniz: ");

        static void NewMethod(int[] sayilar, int i)
        {
            Console.WriteLine(sayilar[i]);
        }

        int adet = Convert.ToInt32(Console.ReadLine());
        if (adet > 1)
        {
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i + 1}.Sayıyı giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Çift Sayılar:");
            for (int i = 0; i < adet; i++)
            {
                if (sayilar[i] % 2 == 0) NewMethod(sayilar,
                                                   i);
            }
        }

        //SORU 2
        Console.Write("kaç adet sayi gireceksiniz?: ");

        int sayiAdeti = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[sayiAdeti];
        for (int i = 0; i < sayiAdeti; i++)
        {
            Console.Write("Lütfen {0}. Sayiyi Giriniz: ", i + 1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Çift Sayilar: ");
        int bolonebilenSayi = 0;
        for (int i = 0; i < sayiAdeti; i++)
        {
            if (sayiDizisi[i] % 2 == 0)
            {
                bolonebilenSayi++;
                Console.Write(sayiDizisi[i] + " ");
            }
        }

        //SORU 3
        Console.WriteLine("kelime adedi:");
        int kelimeadet = int.Parse(Console.ReadLine());
        if (kelimeadet > 1)
        {
            string[] kelimeler = new string[kelimeadet];
            for (int i = 0; i < kelimeadet; i++)
            {
                Console.WriteLine("Kelime giriniz");
                kelimeler[i] = Console.ReadLine();
            }
            Array.Reverse(kelimeler);
            for (int i = 0; i < kelimeadet; i++)
            {
                Console.Write(kelimeler[i]);
            }
        }

        //SORU 4					
        Console.WriteLine("Bir cümle yazınız:");
        string ifade = Console.ReadLine();
        string[] kelimeler_dizi = ifade.Split(' ');
        Console.WriteLine("Kelime sayısı: " + kelimeler_dizi.Length);
        int space = ifade.Count(char.IsWhiteSpace);
        int char_count = ifade.Length - space;
        Console.WriteLine("Harf sayısı: " + char_count);
        Console.ReadKey();
    }
}