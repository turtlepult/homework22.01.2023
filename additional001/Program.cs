// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.
int[] array = {1,2,3,4,5,6,7,20,1,1,1,20};
foreach (var item in array)
{
    Console.Write(item + " ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i]==20)
    {
        array[i] = 200;
break;
    }
}
foreach (var item in array)
{
    Console.Write(item + " ");
}