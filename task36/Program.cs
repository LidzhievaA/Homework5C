// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int SumUnevenIndexElement(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    sum += arr[i];
return sum;
}

int[] array = CreateArray(4, 1, 99);
PrintArray(array);
int sumElement = SumUnevenIndexElement(array);
Console.Write($" -> {sumElement}");