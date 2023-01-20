// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

double MinElement(double[] arr)
{
    double minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElem)
            minElem = arr[i];
    }
    return minElem;
}

double MaxElement(double[] arr)
{
    double maxElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem)
            maxElem = arr[i];
    }
    return maxElem;
}

double[] arrayRndDouble = CreateArrayRndDouble(4, 1, 99);
PrintArrayDouble(arrayRndDouble);

double minimalEl = MinElement(arrayRndDouble);
double maximalEl = MaxElement(arrayRndDouble);

Console.Write($" -> {maximalEl - minimalEl}");