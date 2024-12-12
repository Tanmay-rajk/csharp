using System;
using System.Collections.Generic;
class Inventory
{
static void Main()
{
string name;
List<string>item=new List<string>();
string values;
Console.WriteLine("Enter Your Name");
name=Console.ReadLine();
Console.WriteLine("Enter number of items you want to add in list");
int n=Convert.ToInt32(Console.ReadLine());
for(int i=0;i<n;i++)
{
Console.WriteLine("Enter item name");
values=Console.ReadLine();
item.Add(values);
}
Console.WriteLine("Item in Inventory are:");
string str;
for(int i=0;i<item.Count;i++)
{
str=String.Format("{0}-{1} | ",i,item[i]);
Console.Write(str);
}
char ch='y';
int pos;
Console.WriteLine("\nEnter more item in position\n");
while(ch=='y')
{
Console.WriteLine("Enter position");
pos=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Item");
values=Console.ReadLine();
item.Insert(pos,values);
Console.WriteLine("Do u want continue Adding y/n");
ch= Console.ReadKey().KeyChar;
}
Console.WriteLine("Item in Inventory are:");
for(int i=0;i<item.Count;i++)
{
str=String.Format("{0}-{1} | ",i,item[i]);
Console.Write(str);
}
Console.WriteLine("Do u want Delete item y/n");
ch= Console.ReadKey().KeyChar;
if(ch=='y')
{
Console.WriteLine("Enter item name to remove");
values=Console.ReadLine();
item.Remove(values);
}
Console.WriteLine("{0} Your Final Inventory list",name);
foreach(string val in item)
{
Console.Write(String.Format("{0}|",val));
}
}
}
