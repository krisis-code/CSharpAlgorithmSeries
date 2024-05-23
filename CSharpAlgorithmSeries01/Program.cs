/*Vize ve finale göre ortalama bulan algoritma*/

double Vize, Final, sum  = 0;

Console.WriteLine("Vize puanınızı giriniz");
Vize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Final puanınızı giriniz");
Final = Convert.ToInt32(Console.ReadLine());

sum = (Vize * (0.40)) + (Final * (0.80));

Console.WriteLine("Ortalamanız {0}", sum);



