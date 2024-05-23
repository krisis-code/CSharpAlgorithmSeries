/*Girilen yaşa göre sınıflandıran algoritma:
Bebek =< 14
Ergen = 15 => 19
Delikanlı = 20 => 25
Olgun ve dolgun = 26 => 35
Orta yaş > 36
*/

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
 

