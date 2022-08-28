int start = 10;
int stop = 99;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

int dig_first = value/10;
int dig_second = value - dig_first * 10;

if (dig_first < dig_second)
{
    Console.Write("max =" + dig_second);
}
else
{
    Console.Write("max =" + dig_first);
}
