Console.WriteLine("Ведите  число:");
int k39j1d2i = Convert.ToInt32(Console.ReadLine());
int d21l0k(int d12lzcx1)
{
    while (d12lzcx1 >= 1000)
    {
        d12lzcx1 = d12lzcx1 / 10;
       
    }
return d12lzcx1 % 10;
}
if (k39j1d2i < 0)
{
    k39j1d2i = Math.Abs(k39j1d2i);
}
if (k39j1d2i> 99)
{
    int dwlqd12 = d21l0k(k39j1d2i);
    Console.WriteLine(dwlqd12);
}
else
{
    Console.WriteLine("нет третьей цифры");
}