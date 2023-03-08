Random rand = new Random();
Console.WriteLine("Enter n:");
var s3 = Console.ReadLine();
int n = Convert.ToInt32(s3);
int[,] nums = new int[n, n];
for (int i = 0; i < n; i++) {
    for (int j = 0; j < n; j++)
    {
        nums[i,j]= rand.Next(1, 20);
    }
}
Console.WriteLine("Initial array:");
for(int i=0; i<n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(nums[i, j]+"\t");
    }
    Console.WriteLine();
}
int temp;
for (int j = 1; j < n; j=j+2)
{
    for (int i = 0; i < n-1; i++)
    {
        for (var k = 0; k < n - i-1; k++)
        {
            if (nums[k, j] < nums[k + 1, j])
            {
                temp = nums[k, j];
                nums[k, j] = nums[k + 1, j];
                nums[k + 1, j] = temp;
            }
        }
    }
}

Console.WriteLine("\nResult:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(nums[i, j] + "\t");
    }
    Console.WriteLine();
}
