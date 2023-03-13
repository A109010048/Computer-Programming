int score;
Console.WriteLine("請輸入成績:");
string s = Console.ReadLine();
score = int.Parse(s);

if (score >= 0 && score <= 59)
{
    Console.WriteLine("E");
}
if (score >= 60 && score <= 69)
{
    Console.WriteLine("D");
}
if (score >= 70 && score <= 79)
{
    Console.WriteLine("C");
}
if (score >= 80 && score <= 89)
{
    Console.WriteLine("B");
}
if (score >= 90 && score <= 100)
{
    Console.WriteLine("A");
}
if (score < 0 || score > 100)
{
    Console.WriteLine("輸入錯誤");
}
Console.Read();