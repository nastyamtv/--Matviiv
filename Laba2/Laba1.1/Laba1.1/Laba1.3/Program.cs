Console.WriteLine("Enter n:");
var s3 = Console.ReadLine();
Random rand = new Random();
int n = Convert.ToInt32(s3);
double[] nums = new double[n];
double maximum = 2;
double minimum = -2;
for (int i = 0; i < n; i++)
{
    nums[i] = Math.Round(rand.NextDouble() * (maximum - minimum) + minimum, 2);
}

for (int i = 0; i < n; i++)
{
    Console.Write(nums[i] + " ");
}
Console.WriteLine("\nResult:");
for (int i = 0; i < n; i++) {
    if (Math.Abs(nums[i]) < 1) {
        Console.Write(nums[i]+" ");
    }
}
for (int i = 0; i < n; i++)
{
    if (Math.Abs(nums[i]) >= 1) {
        Console.Write(nums[i] + " ");
    }
}