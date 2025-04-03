Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

//cheak if the subscription had expired 
 if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
// cheak if 1 subscription only as one day left 
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
    
}
//cheak ig there are 2-5 days left 
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
// If there are 6-10 days left, remind the user
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// Display the number of days left for expiration
Console.WriteLine($"Days until expiration: {daysUntilExpiration}");
