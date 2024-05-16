
/* Ekrandan girilen 2 adet sayının toplanmını bulan algoritma 


int a, b, sum = 0;
Console.WriteLine("1. Sayı giriniz");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayı giriniz");
b = Convert.ToInt32(Console.ReadLine());
sum = a + b;
Console.WriteLine("İki sayının toplamı = {0}", sum);
*/

/*İki sayının , Toplamını ,çarpımını bölümünü ve farkını bulan algoritma

float a, b, sum ,dvd,imp,diff= 0;

Console.WriteLine("1. Sayı giriniz");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayı giriniz");
b = Convert.ToInt32(Console.ReadLine());

sum = a + b;
dvd = a / b;
imp = a * b;
diff = a - b;

Console.WriteLine("Toplam = {0} \nÇarpım = {1} \nBölüm = {2} \nFark = {3}", sum, imp, dvd, diff);
 */

/*Vize ve finale göre ortalama bulan algoritma

double Vize, Final, sum  = 0;

Console.WriteLine("Vize puanınızı giriniz");
Vize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Final puanınızı giriniz");
Final = Convert.ToInt32(Console.ReadLine());

sum = (Vize * (0.40)) + (Final * (0.80));

Console.WriteLine("Ortalamanız {0}", sum);

*/

/*Girilen yaşa göre sınıflandıran algoritma:
Bebek =< 14
Ergen = 15 => 19
Delikanlı = 20 => 25
Olgun ve dolgun = 26 => 35
Orta yaş > 36


int age = 0;

Console.WriteLine("Yaşınız");
age = Convert.ToInt32(Console.ReadLine());

if (age <= 14)
	Console.WriteLine("Bebek gibisiniz");
else if (age <= 15 || age <= 19)
	Console.WriteLine("Ergensiniz");
else if (age <= 20 || age <= 25)
	Console.WriteLine("Delikanlım");
else if (age <= 26 || age <= 35)
	Console.WriteLine("Olgun ve dolgun maşallah");
else Console.WriteLine("Orta yaş sendoromu merhabalar aw");
 */

/* Vize ve finale göre ortalama bulan ve harf atayan  algoritma 
 
FF = 0<50
DD = 50=<60
CC = 60 =<75
BB = 75 > <= 90
AA 90 <
 
 

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
*/