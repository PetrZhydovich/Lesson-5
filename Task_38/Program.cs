// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
             //0    1   2   3   4  5   6    7
int[] array = {12, 11, 14, 12, 15, 16, 19, 10};

int sum =0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    
        sum += array[i];
    
} Console.WriteLine(sum);







/*int length = 10;
int[] array = new int[length];
Random rnd = new Random();
 // Console.WriteLine(length);
int sum = 0;
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(1, 70);
      Console.WriteLine(rnd);
    if (array[i] % 2 != 0)
    {
        sum += array[i];
    }
   
}
//Console.WriteLine(length);
Console.WriteLine(sum);
*/