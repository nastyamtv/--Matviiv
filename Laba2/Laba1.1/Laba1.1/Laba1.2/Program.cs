double scalarProduct(double[] a, double[] b, int n)
{
    double x = 0;
    for (int i = 0; i < n; i++)
    {
        x = x + a[i] * b[i];
    }
    return x;
}
void printOnConsole(double[] a, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(a[i] + " ");
    }
}
double[] enterData(double[] m, int n)
{
    var s = Console.ReadLine().Split(' ');
    for (int i = 0; i < n; i++)
    {
        m[i] = Convert.ToDouble(s[i]);
    }
    return m;
}
Console.WriteLine("Enter n:");
var s3 = Console.ReadLine();
int n = Convert.ToInt32(s3);
Random rand = new Random();
double[] a = new double[n];
double[] b = new double[n];
double[] c = new double[n];
enterData(a, n);
enterData(b, n);
enterData(c, n);
Console.Write("Array A:\n");
printOnConsole(a, n);
Console.Write("\nArray B:\n");
printOnConsole(b, n);
Console.Write("\nArray C:\n");
printOnConsole(c, n);
Console.WriteLine("\nResult: "+(2*scalarProduct(a,b,n)-3*scalarProduct(a,c,n)));