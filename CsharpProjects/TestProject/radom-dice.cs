// Create an instance of the Random class to generate random numbers
//Random dice = new Random();

// Generate a random number between 1 and 6 (inclusive)
//int roll = dice.Next(1, 7);

// Print the generated number to the console
//Console.WriteLine("" + roll);

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"Frist roll: {roll1}");
Console.WriteLine($"Frist roll: {roll2}");
Console.WriteLine($"Frist roll: {roll3}");

int fristValue = 500;
int secoundValue = 600;
int largerValue;
largerValue =Math.Max(fristValue, secoundValue);
Console.WriteLine($"The larger value is {largerValue}");

