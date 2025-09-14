double s = 0;
for (double i = Math.Sin(1); i >= Math.Sin(0.15); i = -0.05)
{
    s += i;
}
Console.WriteLine(s);