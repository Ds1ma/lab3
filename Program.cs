double s = 0;
    for(double i = 1; i >= 0.15; i -= 0.05)
{
    s += Math.Sin(i);
}
Console.WriteLine(s);
