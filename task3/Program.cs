double a;
string input;
double result;
input = Console.ReadLine();
a = Double.Parse(input);
result = a % 2;
Console.Write("число чётное?", result);
Console.Write( a % 2 == 0 );
