// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: "); // Запрос числа
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999) // Проверка
{
    int thirdDigit = (number / 100) % 10; 
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("У введенного числа нет третьей цифры."); 
}