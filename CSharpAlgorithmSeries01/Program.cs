
/* Vize ve finale göre ortalama bulan ve harf atayan  algoritma 
 
FF = 0<50
DD = 50=<60
CC = 60 =<75
BB = 75 > <= 90
AA 90 <
 
 */

double Vize, Vize2, Final, sum = 0;

Console.WriteLine("Vize puanınızı giriniz");
Vize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Vize puanınızı giriniz");
Vize2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Final puanınızı giriniz");
Final = Convert.ToInt32(Console.ReadLine());

sum = (((Vize + Vize2)/2)* (0.40)) + (Final * (0.80));

if (sum < 50)
	Console.WriteLine("Notunuz {0} : FF",sum);
else if (sum <= 50 || sum < 60)
	Console.WriteLine("Notunuz {0} : DD", sum);
else if (sum <= 60 || sum <= 75)
	Console.WriteLine("Notunuz {0} : CC", sum);
else if (sum < 75 || sum < 90)
	Console.WriteLine("Notunuz {0} : BB", sum);
else Console.WriteLine("Notunuz {0} : AA", sum);
