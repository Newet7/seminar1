int start = 100;
int stop = 999;

int value = new Random().Next(start, stop+1);
Console.WriteLine(value);

int dig_first = value / 100;
int dig_last = value%10;

Console.WriteLine(dig_first + "" + dig_last);