Random rnd = new Random();
int[] dice = new int[6]{0, 0, 0, 0, 0, 0};

for(int i = 0; i < 20; i++)
{
    int point = rnd.Next(1, 7);
    Console.WriteLine("第{0}次的點數是{1}點", i + 1, point);
    dice[point - 1]++;
}
Console.WriteLine();
for(int j = 0; j < 6; j++)
{
    Console.WriteLine("點數{0}出現{1}次", j + 1, dice[j]);
}

Console.Read();