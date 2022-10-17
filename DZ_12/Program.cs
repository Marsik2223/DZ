// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 44, 5, 78 -> 78

Console.WriteLine("Введите числа");
int number_1= Convert.ToInt32(Console.ReadLine());
int number_2= Convert.ToInt32(Console.ReadLine());
int number_3= Convert.ToInt32(Console.ReadLine());
int max= number_3;
if(number_1> number_3)
{
    Console.WriteLine(max= number_1);
}

if (number_2> number_3)
{
    Console.WriteLine(max= number_2);
}
else 
{
    Console.WriteLine(max= number_3);
}

