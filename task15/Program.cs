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