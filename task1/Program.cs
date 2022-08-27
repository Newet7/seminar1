//int num1 = 5;
//int num2 = 7 ;
//int num1 = 2;
//int num2 = 10 ;
//int num1 = -9;
//int num2 = -3 ;
////int num2_squared = num2*num2;
//if (num1 < num2)
//{
//    Console.Write(num2);
//}
//else
//{
//    Console.Write(num1);
//}

//  var n1 = Decimal.Parse(Console.ReadLine());
//            var n2 = Decimal.Parse(Console.ReadLine());
//            if (n1 > n2)
//               Console.WriteLine(n1);
//           else 
//              Console.WriteLine(n2);

int a;
int b;
string input1;
string input2;

input1 = Console.ReadLine();
input2 = Console.ReadLine();

a = Int32.Parse(input1);
b = Int32.Parse(input2);

if (a < b)
{
    Console.Write( b);
}
else
{
    Console.Write(a);
}