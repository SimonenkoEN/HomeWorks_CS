// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру
// этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSecondDigit(num));

int GetSecondDigit(int number){
    int secDigit = (number % 100) / 10;
    if(secDigit < 0) secDigit *= -1;
    return secDigit;
}