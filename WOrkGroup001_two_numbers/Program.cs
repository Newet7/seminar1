//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int reminder = 0;
int a;
int b;
int reminder = 0;
string input1;
string input2;

input1 = Console.ReadLine();
input2 = Console.ReadLine();

a = Int32.Parse(input1);
b = Int32.Parse(input2);

if (b % a == 0)
{
    Console.Write("b кратно a");
}
else{
    reminder = a%b;
    Console.WriteLine("не кратно, остаток" + reminder);
}