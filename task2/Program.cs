//int [] num1 = {2, 3, 7};
//int maxValue = num1.Max<int>();
//int[] num1 = {2, 3, 7};
//size=3;
//i=0;
//int firstmaxnum = num1[i];
//int secondmaxnum = num1[i];
//while (i<size) do
//    if (num1[i]>secondmaxnum) Then;

//int a = 2;
//int b = 3;
//int c = 7;

//int a = 44;
//int b = 5;
//int c = 78;

//int a = 22;
//int b = 3;
//int c = 9;

//int max=a;
//if (b>max)max=b;
//if (c>max)max=c;
//Console.Write(max);

int a;
int b;
int c;
int max;
string input1;
string input2;
string input3;


input1 = Console.ReadLine();
input2 = Console.ReadLine();
input3 = Console.ReadLine();

a = Int32.Parse(input1);
b = Int32.Parse(input2);
c = Int32.Parse(input3);

//max = a < b;

if (a < b)
{
    max = b;
}
else
{
    max = a;
}

if (max < c)
{
    Console.Write("max =" + c);
}
else
{
    Console.Write("max =" + max);
}