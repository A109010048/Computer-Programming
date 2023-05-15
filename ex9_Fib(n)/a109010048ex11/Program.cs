class Program
{
    static int fibonacci(ref int x)
    {
        if (x == 0) return 0;
        if (x == 1) return 1;
        if (x == 2) return 1;

        int prev1 = 1;
        int prev2 = 1;
        int cur = 0;

        for(int i = 3; i <= x ;i++)
        {
            cur = prev1 + prev2;
            prev1 = prev2;
            prev2 = cur;
        }
        
        return cur;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("input n:");
        int n = int.Parse(Console.ReadLine());

        int result = fibonacci(ref n);
        Console.WriteLine("\nFin({0}) = {1}", n, result);
    }
}