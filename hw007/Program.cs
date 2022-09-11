// Задача 15: Напишите программу, которая принимает
// на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckPartyDay(day));

bool CheckPartyDay(int weekDay){
    bool partyDay = false;
    if(weekDay >= 6 && weekDay <= 7){
        partyDay = true;
    }
    return partyDay;
}