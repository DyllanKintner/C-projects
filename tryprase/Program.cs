/*
string name = "Bob";
Console.WriteLine(int.Parse(name)); // This will throw a System.FormatException because "Bob" cannot be converted to an integer.
*/

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
                 