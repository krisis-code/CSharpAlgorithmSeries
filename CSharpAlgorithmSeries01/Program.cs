/*İki sayının , Toplamını ,çarpımını bölümünü ve farkını bulan algoritma*/

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
 

