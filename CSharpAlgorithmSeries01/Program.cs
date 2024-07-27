int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int sayi in sayilar)
{
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Çift Sayı: " + sayi);
    }
}

char[,] kare = { { '*', '*', '*', '*', '*' }, { '*', '*', '*', '*', '*' }, { '*', '*', '*', '*', '*' }, { '*', '*', '*', '*', '*' }, { '*', '*', '*', '*', '*' } };

int lengt = kare.GetLength(0);

for (int i = 0; i <lengt; i++)
{
    for (int j = 0; j < lengt; j++)
    {
        Console.Write(kare[i, j] + " ");
    }
    Console.WriteLine();


}

//int ucgen = 5;

//for (int i = 0; i <= ucgen; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
int satirSayisi = 10; // Üçgenin yüksekliği

for (int i = 1; i <= satirSayisi; i++)
{
    // Her satır için gerekli boşlukları yazdır
    for (int j = 0; j < (satirSayisi - i); j++)
    {
        Console.Write(" ");
    }

    // '+' karakterlerini yazdır
    for (int k = 0; k < (2 * i - 1); k++)
    {
        Console.Write("+");
    }

    // Satır sonu ve yeni satıra geçiş
    Console.WriteLine();
}