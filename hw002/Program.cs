// Задача 4:
// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третее число: ");
int number_three = Convert.ToInt32(Console.ReadLine());

int max = number_one;

if (number_two > max)
{
    max = number_two;
}
if (number_three > max)
{
    max = number_three;
}

//Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Максимальное число {0}", max);
