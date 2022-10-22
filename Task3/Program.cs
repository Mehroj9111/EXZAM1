var n = Convert.ToInt32(Console.ReadLine());
int[] array;
array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(array);
Array.Reverse(array);
foreach (int i in array)
{
    Console.Write(i + " ");
}