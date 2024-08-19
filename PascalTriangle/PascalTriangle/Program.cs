using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen üçgenin kaç satır içereceğini numerik şekilde belirtin >>");
        int satirSayisi = int.Parse(Console.ReadLine());

        int[][] pascalUcgeni = new int[satirSayisi][];

        //Pascal Üçgenini oluşturmak için : 
        for (int i = 0; i < satirSayisi; i++)
        {
            pascalUcgeni[i] = new int[i + 1];
            pascalUcgeni[i][0] = 1;//pascal üçgeni ilk elemanının her zaman 1 olmasını sağlar
            pascalUcgeni[i][i] = 1;// pascal üçgeninin son elemanın her zaman 1 olmasını sağlar

            for (int x = 1; x < i; x++)// Pascal algoritmasını sağlamak için j'nin başlangıç değerini i+1 olarak belirleniyor.
            {
                pascalUcgeni[i][x] = pascalUcgeni[i - 1][x - 1] + pascalUcgeni[i - 1][x]; //Binom açılımının sade hali i her arttığında j'nin de artacağı durum için koşul (x+y) üzeri 1 ,(x+y) üzeri 2 olarak sağlanacak.
            }
        }
        //Pascal Üçgenini ortalı ve simetrik şekilde yazdırmak için boşluk ekleme
        for (int i = 0; i < satirSayisi; i++)
        {
            Console.Write(new string(' ', (satirSayisi - i - 1) * 2)); // n - i - 1 şu anki satırın başında kaç boşluk olacağını belirler ve 2 ile çarpılarak genişletir.

            for (int x = 0; x <= i; x++)
            {
                Console.Write(pascalUcgeni[i][x] + "  ");//aralarında boşluk olacak şekilde 3 boyutlu i,x dizini yazar
            }
            Console.WriteLine();
        }
    }
}