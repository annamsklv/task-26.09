// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12



Console.WriteLine("Введите число");
string number = Console.ReadLine();
int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    if (int.TryParse(number[i].ToString(), out int result));
    sum = sum + result;    
}

Console.WriteLine($"Сумма цифр в числе: {sum}");