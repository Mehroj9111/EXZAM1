var n = Convert.ToInt32(Console.ReadLine());
int[] array;
int cnt = 0;
array = new int[n];
for (int i = 0; i < n; i++)
{ 
    
    array[i] = Convert.ToInt32(Console.ReadLine());
    for(int j=0; j<i; j++)
    {
if(array[i+1] < array[i-1] && array[i] < array[i+1])
  {
    cnt++;
  }
    }
}
System.Console.WriteLine(cnt+" ");

