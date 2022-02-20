// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = { 2.32, 3.24, 4.17, 5.22, 6.34, 7.47, 8.54, 9.68, 10.12, 20.56 };
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
     max = array[i];
    
    if (array[i] < min) 
    min = array[i];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна - ");
Console.Write(max - min);