// Задача 21. Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними
// в 3D пространстве.

double GetLengthSegment(int[] dotA, int[] dotB)
{
    return Math.Sqrt(Math.Pow(dotA[0] - dotB[0], 2) +
                     Math.Pow(dotA[1] - dotB[1], 2) +
                     Math.Pow(dotA[2] - dotB[2], 2));
}

int[] A1 = { 3, 6, 8 }, B1 = { 2, 1, -7 }; // 15.84
Console.WriteLine(GetLengthSegment(A1, B1));
int[] A2 = { 7, -5, 0 }, B2 = { 1, -1, 9 }; // 11.53
Console.WriteLine(GetLengthSegment(A2, B2));