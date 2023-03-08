using System;

Console.WriteLine("Enter n:");
var s3 = Console.ReadLine();
double res = 1;
bool b = false;
Random rand = new Random();
int n = Convert.ToInt32(s3);
double[] nums = new double[n];
double maximum = 10;
double minimum = -10;
for (int i = 0; i<n; i++) 
{
    nums[i] = Math.Round(rand.NextDouble() * (maximum - minimum) + minimum , 2);
}

for (int i = 0; i < n; i++) {
    Console.Write(nums[i]+" ");
    if (nums[i] < 0) 
    {
        b = true;
        res = res * nums[i];
    }
}
if (b == true)
{
    Console.WriteLine("\nresult= " + Math.Round(res,4));
}
else {
    Console.WriteLine("\nresult= " + 0);
}
