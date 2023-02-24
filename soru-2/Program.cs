namespace soru_2;
class Program
{
    static void Main(string[] args)
    {
        /*
        Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        */

        int[] sayilar = new int[20];
        int[] enBuyuk = new int[3];
        int[] enKucuk = new int[3];
        int enKucukOrt = 0, enKucukTop = 0, enBuyukOrt = 0, enBuyukTop = 0;

        Console.WriteLine("Lütfen 20 Adet Sayı Giriniz.");
        for (int i = 0; i < 20; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            sayilar[i] = n;
        }
        Array.Sort(sayilar);
        for (int i = 0; i < 3; i++)
        {
            enKucuk[i] = sayilar[i];
            enKucukTop += enKucuk[i];
        }
        Console.WriteLine("En küçük sayılar:" +
        enKucuk[0] + "," + enKucuk[1] + "," + enKucuk[2]);

        Array.Reverse(sayilar);
        for (int i = 0; i < 3; i++)
        {
            enBuyuk[i] = sayilar[i];
            enBuyukTop += enBuyuk[i];
        }

        Console.WriteLine("En büyük sayılar:" +
        enBuyuk[0] + "," + enBuyuk[1] + "," + enBuyuk[2]);

        enKucukOrt = enKucukTop / 3;
        Console.WriteLine("En küçük 3 sayının ortalaması: " + enKucukOrt);
        enBuyukOrt = enBuyukTop / 3;
        Console.WriteLine("En büyük 3 sayının ortalaması: " + enBuyukOrt);
        Console.WriteLine("Ortalamalar toplamı: " + (enKucukOrt + enBuyukOrt));

    }
}
