int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int reminder = 0;


if(b % a == 0)
{
    Console.WriteLine ("b кратно a");
}

else
{
    reminder = a%b;
    Console.WriteLine(reminder);
}