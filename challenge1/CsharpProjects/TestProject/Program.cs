string[] IDs = {"B123", "C234", "A345", "C15", "B177", "G3003" ,"C235", "B179"}; 
foreach (string ID in IDs) // Loops through each ID in the array
{
    if (ID.StartsWith("B")) // Checks if the current ID starts with "B"
    {
        Console.WriteLine(ID); // Prints the ID only if it starts with "B"
    }
}
