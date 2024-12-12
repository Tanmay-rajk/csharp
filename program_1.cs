### Program 1 Part-A
using System;
class HelloWorld
{
static void Main()
{
int caseSwitch ;
char ch='y';
while(ch=='y')
{
Console.WriteLine("\nSelect case 1 to 4 for");
caseSwitch =Convert.ToInt32(Console.ReadLine());
int num1,num2,num3;
Console.WriteLine("Enter two numbers");
num1=Convert.ToInt32(Console.ReadLine());
num2=Convert.ToInt32(Console.ReadLine());
num3=0;
switch (caseSwitch)
{
case 1:
num3=num1+num2;
break;
case 2:
num3=num1-num2;
break;
case 3:
num3=num1*num2;
break;
case 4 :
num3=num1/num2;
break;
default:
Console.WriteLine("Value didn't match earlier.");
break;
}
String res=String.Format("Result of {0} and {1} are {2}",num1,num2,num3);
Console.WriteLine(res);
Console.WriteLine("Do u want continue");
ch= Console.ReadKey().KeyChar;
}
}
} 

Part-B
using System;
class Program
{
static void Main(string[] args)
{
// Prompt the user to enter the size of the array
Console.Write("Enter the number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
// Declare an array of size 'n'
int[] numbers = new int[n];
// Input elements into the array
Console.WriteLine("Enter the numbers:");
for (int i = 0; i < n; i++)
{
numbers[i] = Convert.ToInt32(Console.ReadLine());
}
// Calculate the sum of the array elements
int sum = 0;
for (int i = 0; i < n; i++)
{
sum += numbers[i];
}
// Display the sum of the numbers
Console.WriteLine("The sum of the entered numbers is: " + sum);
Console.ReadLine();
}
}
