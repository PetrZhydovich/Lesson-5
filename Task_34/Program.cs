// Написать программу замену элементов массива на противоположные.

    static int [] Input ()
    {
      Console.WriteLine("Введите размерность массива: ");
      int n=int.Parse(Console.ReadLine());
      int []array=new int[n];
      for (int i = 0; i < n; ++i) 
      {
        Console.Write("array[{0}]= ", i); // размерность массива.
        array[i]=int.Parse(Console.ReadLine());
      }
      return array;
    }
 
    static void Print(int[] array) 
    {
      for (int i = 0; i < array.Length; ++i) 
      Console.Write("{0} ", array[i]);
      Console.WriteLine();
    }
 
    static void Change(int[] array) // изненение массива
    {
    for (int i = 0; i < array.Length; ++i)
       if (array[i] > 0) 
        array[i] = -array[i];
    }
    
     int[] myArray=Input();
Console.WriteLine("Исходный массив:");
      Print(myArray);
      Change(myArray);
Console.WriteLine("Измененный массив:");
      Print(myArray);









