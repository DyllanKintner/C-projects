﻿/*Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);


int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");



int frist =2;
string secound = "4";
int result = frist + secound; // This will cause a compile-time error because you cannot add an int and a string directly.
Console.WriteLine(result);

int first = 2;
string second = "4";
string result = first + second; 
Console.WriteLine(result);


int myInt = 3;
Console.WriteLine($"int : {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal : {myDecimal}");

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

int frist = 2;
int secound = 4;   
string message = frist.ToString() + secound.ToString();  // the ToString method converts the int to a string
//57 

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second); // the Parse method converts the string to an int
Console.WriteLine(sum);
*/

string value = "5";
string value2 = "7";
int result = Convert.ToInt32(value) + Convert.ToInt32(value2); // the Convert.ToInt32 method converts the string to an int
Console.WriteLine(result); // 12
string value1s = "5";
string value2s = "7";
int results = Convert.ToInt32(value1s) * Convert.ToInt32(value2s);
Console.WriteLine(results);// 35

// Convert.Toint32 rounds to the nearest whole number but (int)1.5m will just remove the decimal part