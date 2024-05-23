/*1 den 100 kadar sayıların toplamı gauss formülü*/
int sum = 0;

for (int i = 1; i < 100; i++)
    sum = i * (i + 1) / 2;


Console.WriteLine(sum);