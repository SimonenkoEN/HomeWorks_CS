// Задача 2: 
// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());

if (number_one > number_two)
{
    Console.WriteLine("Число " + number_one + " больше числа " + number_two);
}
else if (number_one < number_two)
{
    Console.WriteLine("Число " + number_two + " больше числа " + number_one);
}
else
{
    Console.WriteLine("Числа равны!");
}