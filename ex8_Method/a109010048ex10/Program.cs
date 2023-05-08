class Program
{
    static double CircleArea(double r)
    {
        double a = r * r * 3.14;
        return a;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("請輸入第一個半徑:");
        double r1 = double.Parse(Console.ReadLine());
        Console.WriteLine("請輸入第二個半徑:");
        double r2 = double.Parse(Console.ReadLine());
        Console.WriteLine("請輸入第三個半徑:");
        double r3 = double.Parse(Console.ReadLine());

        Console.WriteLine("當半徑是{0}時，圓面積是{1}", r1, CircleArea(r1));
        Console.WriteLine("當半徑是{0}時，圓面積是{1}", r2, CircleArea(r2));
        Console.WriteLine("當半徑是{0}時，圓面積是{1}", r3, CircleArea(r3));
    }

}