// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность массива");
int demension = int.Parse(Console.ReadLine()??"");
Random rnd = new Random();
int [] arr = new int [demension];

for (int i = 0; i < demension; i++)
{
    arr[i] = rnd.Next(100,1000);
}

string array = string.Join(", ", arr);
Console.WriteLine(array);

int count = 0;
for (int i = 0; i < demension; i++)
{
    if(arr[i] % 2 == 0)
    count++;
}

Console.WriteLine(count);