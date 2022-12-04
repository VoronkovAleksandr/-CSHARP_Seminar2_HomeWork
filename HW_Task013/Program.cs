// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
int n = number;
string result = "В числе " + number + " третьей цифры нет.";

if (number > 100) 
{
    while (n > 1000)
    {
        n /=10;
    }
    n = n % 10;
    result = "Третья цифра в числе " + number + " -> " + n;
}

Console.WriteLine(result);