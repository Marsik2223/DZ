// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
Console.WriteLine("Введите числа");
int number_1= Convert.ToInt32(Console.ReadLine());
int number_2= Convert.ToInt32(Console.ReadLine());
int max= number_2;
if(number_1> number_2)
{
    Console.WriteLine("Первое число больше второго");
}

if (number_2> number_1)
{
    Console.WriteLine("Второе число больше первого");
}
else 
{
    Console.WriteLine(max= number_2);
}
