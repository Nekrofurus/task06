// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число чётным
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
Console.WriteLine("Да, четное");
else
Console.WriteLine("Нет, нечетное");