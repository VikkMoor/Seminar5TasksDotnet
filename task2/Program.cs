// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1)
    {
        arr1[pos1] = new Random().Next(-10, 11);
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

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int len = array.Length;
for (int i = 0; i < len; i++) array[i] = array[i] * (-1);
PrintArray(array);