// Задача 13: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetThirdDigit(num));

string GetThirdDigit(int numbeer){
    string thirdDig = "";
    if(numbeer < 0) numbeer *= -1;
    if(numbeer > 99){
        char[] arr = numbeer.ToString().ToCharArray();
        thirdDig = arr[2].ToString();
    }
    else{
        thirdDig = "В этом числе нет третьей цифры!";
    }
    return thirdDig;
}