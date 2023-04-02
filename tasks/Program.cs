// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine($"число '{number}'");
int result = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{result}'");
 

 // Задача 13: Написать программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return false;
    }
return true;
}
int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}


// Задача 15: Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
int number = new Random().Next(1, 8);
Console.WriteLine($"Weekday '{number}'");
if (number >= 1 && number <=7) 
{
    if (number >= 6) 
    {
        Console.Write("It's a day off");
    }
	else
    {
        Console.Write("It's a working day");
    }
}