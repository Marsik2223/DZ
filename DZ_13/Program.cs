// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 22 3 9 -> 22

Console.WriteLine("Введите числа");
int number_1= Convert.ToInt32(Console.ReadLine());
int number_2= Convert.ToInt32(Console.ReadLine());
int number_3= Convert.ToInt32(Console.ReadLine());
int max= number_1;
if(number_2> number_1)
{
    Console.WriteLine(max= number_1);
}

if (number_3> number_1)
{
    Console.WriteLine(max= number_2);
}
else 
{
    Console.WriteLine(max= number_1);
}
