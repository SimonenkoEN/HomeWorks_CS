//  Задача 25: Напишите цикл, который принимает на вход два числа
//  (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
bool isNum = int.TryParse(Console.ReadLine(), out int num);
while(!isNum)
{
    Console.Write("Неверное значение! Повторите ввод: ");
    isNum = int.TryParse(Console.ReadLine(), out num);
}

Console.Write("Введите натуральную степень: ");
bool isPow = int.TryParse(Console.ReadLine(), out int pow);
while(pow < 1)
{
    Console.Write("Неверное значение! Повторите ввод: ");
    isPow = int.TryParse(Console.ReadLine(), out pow);
}

Console.WriteLine(RaisToNaturalPower(num, pow));

int RaisToNaturalPower(int number, int power)
{
    int raisingNumber = 1;
    for (int i = 1; i <= power; i++)
    {
        raisingNumber *= number;
    }
    return raisingNumber;
}