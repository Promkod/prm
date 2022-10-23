int a = 12;
int b = 233;
int max = a;
int min = b;

if (max > min)
{
    max = a;
    min = b;
}

if (max < min)
{
    max = b;
    min = a;
}



Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);