Random rand = new Random();
Console.WriteLine("Enter n and m:");
var s3 = Console.ReadLine().Split(" ");
int n = Convert.ToInt32(s3[0]);
int m = Convert.ToInt32(s3[1]);
int[] character = new int[m];
int[] character_ind = new int[m];
int[,] nums = new int[n, m];
int[,] res = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j <m; j++)
    {
        nums[i, j] = rand.Next(-20, 20);
    }
}
Console.WriteLine("Initial array:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(nums[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nCharacteristic:");

for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {
        if ((nums[i, j] < 0) && (Math.Abs(nums[i, j]) % 2 == 1))
        {
            character[j] = character[j] + Math.Abs(nums[i, j]);
        }

    }
    character_ind[j] = j;
    Console.Write(character[j] + "\t");
}
int temp;
for (int i = 0; i<m; i++){
    for (int j = 1; j < m - i; j++) {
        if (character[j] < character[j - 1]) {
            temp = character_ind[j];
            character_ind[j] = character_ind[j - 1];
            character_ind[j - 1]    = temp;
            temp = character[j];
            character[j] = character[j - 1];
            character[j - 1] = temp;
        }
    }
}
Console.WriteLine("\n\nSorted");
for (int i = 0; i < m; i++) {
    Console.Write(character_ind[i]+"\t");
}

int x = 0;
for (int k=0; k < m; k++)
{
    int j = character_ind[k];
    for (int i = 0; i < n; i++)
    {
        res[i, x] = nums[i, j];
        
    }
    x++;
}

Console.WriteLine("\n\nResult:");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(res[i, j] + "\t");
    }
    Console.WriteLine();
}
