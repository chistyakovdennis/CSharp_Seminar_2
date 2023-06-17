// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели (1-7):");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek >= 1 && dayOfWeek <= 7)
{
    if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        Console.WriteLine("День недели является выходным.");
    }
    else
    {
        Console.WriteLine("День недели не является выходным.");
    }
}
else
{
    Console.WriteLine("Некорректный номер дня недели.");
}