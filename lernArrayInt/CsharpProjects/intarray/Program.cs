int[] inventory = {200, 450, 700, 175, 250};// this is an array 
int sum = 0; // Initializes sum to store the total number of items 

int bin = 0; //Initializes bin to track the bin number.
 

foreach (int items in inventory)// loops though each ietm in the inventory array
{
    sum += items; // adds 0 + 200 then 200 + 450 ect
    bin++; //adds 1 to bin so 0 +1 the next loop 1+1 ect 
    // Prints the bin number, item count, and running total of items.
    Console.WriteLine($"Bin {bin} = {items} items (running total: {sum})"); 
}
// Prints the total number of items in all bins combined.
Console.WriteLine($"We have {sum} items in inventory."); 
