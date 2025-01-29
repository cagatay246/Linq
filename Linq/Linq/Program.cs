class Program
{
    static void Main()
    {
        Random rand = new Random();
        List<int> sayilar = Enumerable.Range(0, 10).Select(_ => rand.Next(-50, 50)).ToList();

        Console.WriteLine("Liste: " + string.Join(", ", sayilar));

        var ciftSayilar = sayilar.Where(s => s % 2 == 0);
        Console.WriteLine("Çift sayılar: " + string.Join(", ", ciftSayilar));

        var tekSayilar = sayilar.Where(s => s % 2 != 0);
        Console.WriteLine("Tek sayılar: " + string.Join(", ", tekSayilar));

        var negatifSayilar = sayilar.Where(s => s < 0);
        Console.WriteLine("Negatif sayılar: " + string.Join(", ", negatifSayilar));

        var pozitifSayilar = sayilar.Where(s => s > 0);
        Console.WriteLine("Pozitif sayılar: " + string.Join(", ", pozitifSayilar));

        var belirliAralik = sayilar.Where(s => s > 15 && s < 22);
        Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", belirliAralik));

        var karelerListesi = sayilar.Select(s => s * s).ToList();
        Console.WriteLine("Listedeki sayıların kareleri: " + string.Join(", ", karelerListesi));
    }
}

