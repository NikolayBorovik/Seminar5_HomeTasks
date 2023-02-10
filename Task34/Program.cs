// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size)
{
    int[] collection = new int[size];

    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(100,1000);
    }
System.Console.WriteLine(String.Join(" ", collection));
return collection;
}

int[]array = GetArray(15);

int QtyOfEvenNumbers (int[] collection)
{
    int count = 0;
    foreach (var item in collection)
    {
        count += item%2 == 0 ? 1 : 0;
    }
    return count;
}

int result = QtyOfEvenNumbers(array);

System.Console.WriteLine($"The quantity of even numbers in the array is {result}");