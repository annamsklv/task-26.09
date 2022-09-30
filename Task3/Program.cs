// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// ввод элеменетов через консоль (через запятую. использовать метод string.Split())


string[] PrintArray(string arrayStr)
{
    string [] array = arrayStr.Split(", ");
    return array;
}

Console.WriteLine("Введите элемены массива через запятую");
string arrayStr = Console.ReadLine()??"";
int arrayLenght = arrayStr.Length;
string [] array = PrintArray(arrayStr);
for (var i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]},");
}

