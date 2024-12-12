using System;
using System.Collections.Generic;
class Program
{
public static void Main()
{
Dictionary<int, string> country = new Dictionary<int,
string>();
Console.WriteLine("Enter number of items you want to add in
Dictionary");
int n = Convert.ToInt32(Console.ReadLine());
int countryCode;
string countryName;
for (int i = 0; i < n; i++)
{
Console.WriteLine("Enter Country Code");
countryCode = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Country Name");
countryName = Console.ReadLine();
country.Add(countryCode, countryName);
}
Console.WriteLine("Dictionary Data is:");
foreach (KeyValuePair<int, string> entry in country)
{
Console.WriteLine(entry.Key + " : " + entry.Value);
}
Console.WriteLine("Enter key to find the value");
int key = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Value having key {0} is {1}", key,
country[key]);
// Update Dictionary Data
Console.WriteLine("Enter the key to Edit Value");
int updateKey = Convert.ToInt32(Console.ReadLine());
if (country.ContainsKey(updateKey))
{
Console.WriteLine("Enter new value for the key {0}:",
updateKey);
country[updateKey] = Console.ReadLine();
}
else
{
Console.WriteLine("Key not found.");
}
Console.WriteLine("Updated Dictionary Data:");
foreach (KeyValuePair<int, string> entry in country)
{
Console.WriteLine(entry.Key + " : " + entry.Value);
}
// Remove Value
Console.WriteLine("Enter the key of the Value you want to
remove:");
int removeKey = Convert.ToInt32(Console.ReadLine());
if (country.ContainsKey(removeKey))
{
country.Remove(removeKey);
}
else
{
Console.WriteLine("Key not found.");
}
Console.WriteLine("Final Dictionary Data:");
foreach (KeyValuePair<int, string> entry in country)
{
Console.WriteLine(entry.Key + " : " + entry.Value);
}
}
}
