// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = GetArray(7);

double[] GetArray (int size)
{
    double[] collection = new double[size];
    for (int i = 0; i < size; i++) 
    {
    Random rand = new Random();
    double min = 1;
    double max = 10;
    double range = max - min;
    for (int j = 0; j < 10; j++)
        {
            double sample = rand.NextDouble();
            double scaled = (sample * range) + min;
            scaled = Math.Round(scaled, 1);
            collection[i] = scaled;
        }
    }
    return collection;
}

System.Console.WriteLine(String.Join(" ", array));

double MaxMinNumDiff (double[] collection)
{
    double max = 0;
    double min = collection[0];
    foreach (var item in collection)
    {
        if (item > max) max = item;
        else if(item<min) min = item;
    }
    double diff = max - min;
    diff = Math.Round(diff,1);
    return diff;
}

double result = MaxMinNumDiff(array);
System.Console.WriteLine(result);