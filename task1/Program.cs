// The sum of negative and positive numbers.

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1)
    {
        arr1[pos1] = new Random().Next(-9, 10);
        pos1++;
    }
}

void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr2[pos2]}, ");
        pos2++;
    }
    Console.WriteLine();
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);

int sum1 = 0, sum2 = 0;
int len = array.Length;
for (int i = 0; i < len; i++)
{
    if (array[i] < 0) sum1 = sum1 + array[i];
    else sum2 = sum2 + array[i];
}
Console.Write($"Negative numbers sum: {sum1}, positive numbers sum: {sum2}");
