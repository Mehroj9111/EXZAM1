var n = Convert.ToInt32(Console.ReadLine());
int[] array;
array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
if(array[i]>array[i+1] && array[i+1]>array[i-1])
{
    System.Console.WriteLine(array[i+1] );
}
else {
    System.Console.WriteLine(array[i]);
}    
    

}

