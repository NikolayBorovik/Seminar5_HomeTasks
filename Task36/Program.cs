// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetArray(15);

int[] GetArray (int size)
{
    int[] collection = new int[size];
    for (int i = 0; i < size; i++) collection[i] = new Random().Next(-99,+99);
    return collection;
}

int QtyOfOddIndNums (int[] collection)
{
    int count = 0;
   for (int i = 1; i < collection.Length; i+=2)
   {
        count += collection[i];
   }
   return count;
}

int result = QtyOfOddIndNums(array);

System.Console.WriteLine(String.Join(" ", array));
System.Console.WriteLine(result);