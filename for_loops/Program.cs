﻿//dotnet run 
/*
for (int i = 0; i < 10; i ++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/

/*
string [] names = { "Alex", "Eddie", "David", "Mihchael"};
for (int i = names.Length -1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/

/*
string [] names = { "Alex", "Eddie", "David", "Mihchael"};
for (int i =0; i < names.Length; i ++)
{
    if (names[i] == "David") 
    {
    names[i] = "Sammy";
    }
}

foreach (var name in names) 
{
    Console.WriteLine(name);
}
*/

//challge 1

for (int i = 0; i < 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}