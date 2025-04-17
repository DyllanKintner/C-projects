/*
Random random = new Random();
int heroDamage = random.Next(1, 11);
int monsterDamage = random.Next(1, 11);

int heroHealth = 10;
int monsterHealth = 10;

while (heroHealth > 0 && monsterHealth > 0)
{
    Console.WriteLine($"Hero Health: {heroHealth} | Monster Health: {monsterHealth}");
    Console.WriteLine("Press Enter to attack the monster...");
    Console.ReadLine();

    monsterHealth -= heroDamage;
    Console.WriteLine($"You dealt {heroDamage} damage to the monster!");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("You defeated the monster!");
        break;
    }

    heroHealth -= monsterDamage;
    Console.WriteLine($"The monster dealt {monsterDamage} damage to you!");

    if (heroHealth <= 0)
    {
        Console.WriteLine("You were defeated by the monster!");
        break;
    }
}

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

Console.WriteLine("Enter a number between 5 and 10:");
int numericValue = 0;
bool validNumber = false;
readResult = null;

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (validNumber == false || numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
        else
        {
            Console.WriteLine($"You entered a valid number: {numericValue}");
        }
    }
} while (validNumber == false);


Console.WriteLine("role names: Admininstrator, Manager , User");
string role = Console.ReadLine() ?? string.Empty;
bool validEntry = false;


do
{
    string cleranedRole = role.Trim().ToLower();

    if (cleranedRole == "admininstrator")
    {
        Console.WriteLine("You have full access to the system.");
        validEntry = true;
    }
    else if (cleranedRole == "manager")
    {
        Console.WriteLine("You have limited access to the system.");
        validEntry = true;
    }
    else if (cleranedRole == "user")
    {
        Console.WriteLine("You have basic access to the system.");
        validEntry = true;
    }
    else
    {
        Console.WriteLine("Invalid role. Please enter a valid role name:");
        role = Console.ReadLine() ?? string.Empty;  
    }
} while (validEntry == false);
    
    */

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}