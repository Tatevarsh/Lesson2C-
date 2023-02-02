// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
Console.Clear();

Console.WriteLine("Введите число:");
int N =Math.Abs(int.Parse(Console.ReadLine()!));;

if (N < 100)
{
    Console.WriteLine("В этом числе 3-я цифра отсутствует");
}

while (N >= 100 )
{
    if (N < 1000)
    {
        int Number = N % 10;
        Console.WriteLine("Третья цифра в числе: " + Number);
    }
    N = N / 10;
}











