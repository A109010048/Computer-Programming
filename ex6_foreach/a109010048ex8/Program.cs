int[] pw = new int[10] { 123, 456, 789, 147, 258, 369, 159, 357, 951, 753 };
Console.WriteLine("請輸入密碼:");
int input = int.Parse(Console.ReadLine());
foreach (int i in pw)
{
    if (i == input)
    {
        Console.WriteLine("驗證成功");
        break;
    }
    if (i == 753 && i != input)
        Console.WriteLine("驗證失敗");
}
Console.Read();