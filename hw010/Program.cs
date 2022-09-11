// Задача 23. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.

// string GetListCube(int num)
// {
//     string listCube = "1";
//     for (int n = 2; n <= num; n++)
//     {
//         listCube = listCube + ", " + Math.Pow(n, 3).ToString();
//     }
//     return listCube;
// }

// Console.WriteLine(GetListCube(new Random().Next(1, 6)));

double[] GetListCube(int number)
{
    double[] listCube = new double[number];

    for (int i = 0; i < listCube.Length; i++)
    {
        listCube[i] = Math.Pow((i+1), 3);
    }
    return listCube;
}

int num = Convert.ToInt32(Console.ReadLine());

double[] arr = GetListCube(num);
foreach(int el in arr)
{
    System.Console.Write(el + " ");
}