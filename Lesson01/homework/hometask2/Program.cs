int a = 5;
int b = 7;
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