// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] arr1)
{
    int len1 = arr1.Length;
    int pos1 = 0;
    while (pos1 < len1) { arr1[pos1] = new Random().Next(0, 101); pos1++; }
}
void PrintArray(int[] arr2)
{
    int len2 = arr2.Length;
    int pos2 = 0;
    while (pos2 < len2) { Console.Write($"{arr2[pos2]} "); pos2++; }
    Console.WriteLine();
}
Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
bool check = false;
Console.Write("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < size; i++)
{
    if (array[i] == input) {Console.Write("Here!");check = false; break;}
    else check = true;
}
if (check) Console.Write("None");