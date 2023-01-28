// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[10];
int Count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int j = 0; j < array.Length; j++)
{
    if (array[j]%2 == 0)
        Count++;
}

foreach (var item in array)
{
    Console.Write(item + " ");
}
Console.WriteLine("четных числе в массиве - "+Count);