using System.Collections;

namespace soru_1;
class Program
{
    static void Main(string[] args)
    {
        /*
        Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        - Negatif ve numeric olmayan girişleri engelleyin.
        - Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        - Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

        */
        ArrayList sayilar = new ArrayList();
        ArrayList asalSayi = new ArrayList();
        ArrayList asalOlmayanSayi = new ArrayList();
        int asalSayilar = 0, asalOlmayanSayilar = 0, asalOrtalama = 0, asalOlmayanOrtalama = 0, asalToplam = 0, asalOlmayanToplam = 0;

        Console.WriteLine("Lütfen 20 adet pozitif sayı giriniz.");
        for (int i = 0; i < 20; i++)
        {
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi <= 0)
                {
                    Console.WriteLine("Pozitif bir sayı giriniz.");
                }

                else
                {
                    sayilar.Add(sayi);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Girilen veri tipi uygun değil. Girilen değer bir sayı olmalıdır.");
            }
        }
        foreach (var item in sayilar)
        {
            if (AsalMı(Convert.ToInt32(item)) == true)
            {
                asalSayi.Add(item);
                asalSayilar++;
                asalToplam = asalToplam + Convert.ToInt32(item);
            }
            else
            {
                asalOlmayanSayi.Add(item);
                asalOlmayanSayilar++;
                asalOlmayanToplam = asalOlmayanToplam + Convert.ToInt32(item);
            }
        }

        asalOrtalama = asalToplam / asalSayilar;
        asalOlmayanOrtalama = asalOlmayanToplam / asalOlmayanSayilar;

        asalSayi.Sort();
        asalSayi.Reverse();
        asalOlmayanSayi.Sort();
        asalOlmayanSayi.Reverse();

        Console.Write("Asal Sayilarin büyükten kücüge dogru siralanmasi: ");
        foreach (var item in asalSayi)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Asal Sayilar dizisinin eleman sayisi:" + asalSayilar);
        Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOrtalama);

        Console.Write("Asal Olmayan Sayilarin büyükten kücüge dogru siralanmasi: ");
        foreach (var item in asalOlmayanSayi)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Asal Olmayan Sayilar dizisinin eleman sayisi:" + asalOlmayanSayilar);
        Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOlmayanOrtalama);


    }
    public static bool AsalMı(int sayi)
    {
        int sayac = 0;
        bool asal;
        int i;

        for (i = 1; i <= sayi; i++)
        {
            if (sayi % i == 0)
            {
                sayac++;
            }
        }

        if (sayac == 2)
        {
            asal = true;
        }

        else
        {
            asal = false;
        }

        return asal;
    }
}
