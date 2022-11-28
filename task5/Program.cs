// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1)
    {
        arr1[pos1] = new Random().Next(0, 10);
        pos1++;
    }
}
void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2)
    {
        Console.Write($"{arr2[pos2]} ");
        pos2++;
    }
}
Console.Write("Enter array size: ");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size1];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int size2;
if (size1 % 2 == 0) size2 = size1 / 2;
else size2 = size1 / 2 + 1;
int[] array2 = new int[size2];
for (int i = 0; i < array.Length / 2; i++)
{
    if (size1 % 2 == 0) array2[i] = array[i] * array[size1 - 1 - i];
    else { array2[i] = array[i] * array[size1 - 1 - i]; array2[size2 - 1] = array[size1 / 2];}
}
PrintArray(array2);
