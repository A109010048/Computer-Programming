Random rnd = new Random();
int[] dice = new int[20];
int p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0;

for(int i = 0; i < 20; i++)
{
    int point = rnd.Next(1, 7);
    dice[i] = point;
    Console.WriteLine("第{0}次的點數是{1}點", i + 1, point);
    if (point == 1)
        p1++;
    else if (point == 2)
        p2++;
    else if (point == 3)
        p3++;
    else if (point == 4)
        p4++;
    else if (point == 5)
        p5++;
    else
        p6++;
}

Console.WriteLine("\n點數1出現{0}次",p1);
Console.WriteLine("點數2出現{0}次",p2);
Console.WriteLine("點數3出現{0}次",p3);
Console.WriteLine("點數4出現{0}次",p4);
Console.WriteLine("點數5出現{0}次",p5);
Console.WriteLine("點數6出現{0}次",p6);

Console.Read();