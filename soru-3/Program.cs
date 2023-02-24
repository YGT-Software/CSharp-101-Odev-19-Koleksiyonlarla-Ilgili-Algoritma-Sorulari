namespace soru_3;
class Program
{
    static void Main(string[] args)
    {
        /*
        Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
        */
        Console.WriteLine("Lütfen bir cümle giriniz");
        string sentence = Console.ReadLine();
        sentence.ToLower();

        string sesli = "ıiuüoöae";

        int sentencelength = sentence.Count();

        List<char> sesliList = new List<char>();
        for (int i = 0; i < sentencelength; i++)
        {
            if (sesli.Contains(sentence[i]))
            {
                if (!sesliList.Contains(sentence[i]))
                {
                    sesliList.Add(sentence[i]);
                }

            }
        }

        Console.Write("Cümledeki sesli harfler= ");
        foreach (var item in sesliList)
        {
            Console.Write(item + ", ");
        }


        Console.ReadLine();
    }
}
