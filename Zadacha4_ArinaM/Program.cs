Console.WriteLine("Введите 3 числа");
int a, b, d, max;
Console.WriteLine("Введите первое число - "); 
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число - ");
d = Convert.ToInt32(Console.ReadLine());

max = a;
 
if (b>max)
max = b;

if (d>max)
max = d;

Console.WriteLine($"Максимальное число - {max}");