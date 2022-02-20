//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
}
void PrintArray(int[] col) 
{
    int count = col.Length;
    int position = 0; 
    while (position < count)
    {
        Console.WriteLine($"{col[position]} ");
        position++;
    }
}
void EvenNumbers(int[] even)
{  
     int numEven = 0;
    int numOdd = 0;

    for (int i = 0; i < even.Length; i++)
    {
    if (even [i] % 10 == 0)
    {
    numEven++;
    }

    if (even [i] % 10 != 0)
    {
        numOdd++;
    }
    Console.WriteLine($"Количество чётных чисел: {numEven}");
    Console.WriteLine($"Количество нечетных чисел: {numOdd}");
    }
}

int[] array = new int[8]; 

FillArray(array); 
PrintArray(array); 
EvenNumbers(array);
