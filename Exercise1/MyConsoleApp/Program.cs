string permission = "Admin|Manager";
int level = 55;

Console.WriteLine(permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user." : "Welcome, user.");
Console.WriteLine(permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user." : "Welcome, user.");
Console.WriteLine(permission.Contains("manager") && level > 20 ? "contact and admin for access" : "Welcome, user.");
Console.WriteLine(
    !permission.Contains("Admin") && !permission.Contains("Manager")
    ? "You do not have sufficient privileges."
    : "Welcome, user."
);


string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}