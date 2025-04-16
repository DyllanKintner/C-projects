// Create a new instance of the Random class to generate random numbers
Random random = new Random();

// Generate an initial random number between 1 and 10 (inclusive)
int current = random.Next(1, 11);

do
{
    // Generate a new random number between 1 and 10 (inclusive)
    current = random.Next(1, 11);

    // If the generated number is 8 or greater, skip the rest of the loop iteration
    if (current >= 8) continue;

    // Print the current number to the console
    Console.WriteLine(current);

    // Continue looping until the generated number is 7
} while (current != 7);

/*
The following block of code is commented out. If uncommented, it would:
1. Continue looping while the current number is 3 or greater.
2. Print the current number to the console.
3. Generate a new random number between 1 and 10 (inclusive) in each iteration.
4. Print the last generated number after exiting the loop.

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

//  challenge 1

