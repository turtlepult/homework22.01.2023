// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,100);
}
foreach (var item in array)
{
    Console.Write(item+" ");
}
int max = array[0];
int min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j]>max)
    {
        max = array[j];
    }
    else if (array[j]<min)
    {
        min = array[j];
    }
}
Console.WriteLine("max - "+max+", min - "+min);
int diff = 0;
diff = max-min;
Console.WriteLine("diff - "+diff);