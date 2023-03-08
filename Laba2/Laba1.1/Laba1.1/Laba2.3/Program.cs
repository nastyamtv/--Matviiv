Random rand = new Random();
Console.WriteLine("Enter n:");
var s3 = Console.ReadLine();
int n = Convert.ToInt32(s3);
int[,] nums = new int[n, n];
int[] b = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = rand.Next(-5, 20);
    }
}
Console.WriteLine("Initial array:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(nums[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nBoolean:");

for (int j = 0; j < n; j++)
{
    for (int i = 0; i < n; i++)
    {
        if (nums[i, j] < 0) {
            b[j] = 1;
        }
        
    }
    Console.Write(b[j] + "\t");
}
Console.WriteLine("\nResult:\n");
int sum = 0;
for (int j = 0; j < n; j++)
{
    if (b[j] == 1) { 
    for (int i = 0; i < n; i++)
    {
        sum = sum + nums[i,j];
    }
    Console.Write(sum+"\t");
    sum = 0;
}
else {
    Console.Write("0\t");
}
}