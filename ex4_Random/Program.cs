Random rnd = new Random();
int s;
int play = 1;
int T = 0, L = 0, W = 0;

Console.WriteLine("遊戲規則：\n3贏2\n2贏1\n1贏3");

while (play == 1)
{
    Console.WriteLine("\n請輸入出拳 1 、 2 或 3 :");
    s = int.Parse(Console.ReadLine());
    Console.WriteLine("\n你的出拳為{0}", s);
    int temp = rnd.Next(1,4);
    Console.WriteLine("隨機出拳為{0}", temp);

    if (s == 1)
    {
        if (temp == 1)
        {
            Console.WriteLine("平手");
            T += 1;
        }
        else if (temp == 2)
        {
            Console.WriteLine("你輸了");
            L += 1;
        }
        else if (temp == 3)
        {
            Console.WriteLine("你贏了");
            W += 1;
        }
        else
        {
            Console.WriteLine("輸入錯誤");
        }
    }
    if (s == 2)
    {
        if (temp == 2)
        {
            Console.WriteLine("平手");
            T += 1;
        }
        else if (temp == 3)
        {
            Console.WriteLine("你輸了");
            L += 1;
        }
        else if (temp == 1)
        {
            Console.WriteLine("你贏了");
            W += 1;
        }
        else
        {
            Console.WriteLine("輸入錯誤");
        }
    }
    if (s == 3)
    {
        if (temp == 3)
        {
            Console.WriteLine("平手");
            T += 1;
        }
        else if (temp == 1)
        {
            Console.WriteLine("你輸了");
            L += 1;
        }
        else if (temp == 2)
        {
            Console.WriteLine("你贏了");
            W += 1;
        }
        else
        {
            Console.WriteLine("輸入錯誤");
        }
    }
    Console.WriteLine("你要繼續玩嗎 [0] 否 [1] 是 :");
    play = int.Parse(Console.ReadLine());
}
if (play == 0)
{
   Console.WriteLine("你平手了{0}次，輸了{1}次，贏了{2}次", T, L, W); 
}

Console.Read();