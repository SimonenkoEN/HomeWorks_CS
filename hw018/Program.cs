// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для нахождения точки пересечения прямых, заданных уравнениями");
Console.WriteLine("y=k1*x+b1 и y=k2*x+b2, введите значения коэффициентов");
Console.WriteLine("ВНИМАНИЕ! Если k1=k2, прямые не пересекаются или совпадпют.");

Console.Write("k1 = ");
double k1 = GetValidNumber();

Console.Write("b1 = ");
double b1 = GetValidNumber();

Console.Write("k2 = ");
double k2 = GetValidNumber();

while (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются или совпадпют, введите другое значение");
    Console.Write("k2 = ");
    k2 = GetValidNumber();
}

Console.Write("b2 = ");
double b2 = GetValidNumber();

double[] coordinates = FoundCrossingCoordinates(k1, b1, k2, b2);
Console.WriteLine($"Прямые пересекаются в точке с координатами x={coordinates[0]}, y={coordinates[1]}");

// для двух прямых y=a1*x+b1 и y=a2*x+b2
double[] FoundCrossingCoordinates(double a1, double b1, double a2, double b2)
{
    double[] arrayXY = new double[2];
    arrayXY[0] = (b2 - b1) / (a1 - a2);
    arrayXY[1] = a1 * ((b2 - b1) / (a1 - a2)) + b1;

    return arrayXY;
}

double GetValidNumber()
{
    bool isNumber = double.TryParse(Console.ReadLine(), out double number);
    while (!isNumber)
    {
        Console.Write("Введе число: ");
        isNumber = double.TryParse(Console.ReadLine(), out number);
    }
    return number;
}