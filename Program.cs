Console.WriteLine("введите R1");
double R1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите R2");
double R2 = Convert.ToDouble(Console.ReadLine());
double P = Math.PI;
double d = (P * Math.Pow(R2, 2));
double d1 = (P * Math.Pow(R1, 2));
double S = d - d1;
Console.WriteLine(S);
