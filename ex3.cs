int month;
Console.WriteLine("請輸入月份:");
month = int.Parse(Console.ReadLine());
switch (month)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("第一季");
        break;
    case 4:
    case 5:
    case 6:
        Console.WriteLine("第二季");
        break;
    case 7:
    case 8:
    case 9:
        Console.WriteLine("第三季");
        break;
    case 10:
    case 11:
    case 12:
        Console.WriteLine("第四季");
        break;
    default:
        Console.WriteLine("輸入錯誤");
        break;
}
Console.Read();
