Console.WriteLine("введите число");
int K = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите элементы массива");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        nums[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i < a; i++)
{
    for (int j = 0;j < b; j++)
    {
        if (nums[i, j] > K)
        {
            Console.WriteLine($"{nums[i, j]} > {K}");
        }
    }
}