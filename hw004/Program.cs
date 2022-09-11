// Задача 8:
// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());

int even = 2;
Console.Write("Четные числа от 0 до " + number + ": ");

while (even <= number)
{
    Console.Write(even + " ");
    even += 2;

}