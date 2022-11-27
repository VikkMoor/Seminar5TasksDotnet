string s = "1, 2, 3, 4, 5, 6, 7.";
string[] nums = s.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] n = nums.Select(Int32.Parse).ToArray();
foreach (var num in n)
{
    Console.WriteLine(num + 10);
}
