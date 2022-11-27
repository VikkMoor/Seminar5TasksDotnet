int i, rem = 0, newnum = 0;
Console.Write("Enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());
for (i = input; i > 0; i = (i / 10))
{
    rem = i % 10;
    newnum = (newnum * 10) + rem;
}
if (newnum == input) Console.WriteLine("Palindrome");
else Console.WriteLine("Not palindrome");