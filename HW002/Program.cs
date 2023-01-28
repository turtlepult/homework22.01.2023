// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    if (i%2!=0)
    {
        Console.WriteLine(array[i]+" ");
    }
}