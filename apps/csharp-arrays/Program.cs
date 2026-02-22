// this is a very weird syntax compared to others, but, yeah,
// it means `the array of strings fraudulentOrderIDs equals to
// a new string array with length equal to 3
// like in many other programming languages, this means it 
// is a fixed length array, so, there's only 3 spaces availables inside:
// [0], [1] and [2]
/*
string[] fraudulentOrderIDs = new string[3];
// Alternatively we can define and assign in one statement:
// string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
// Or with the older syntax:
// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"The fraudulentOrderIDs has {fraudulentOrderIDs.Count()} positions");
// Even though it may not look like that, I was expecting this to print out 0,
// because right now, the array is empty, sounds logic, right? Well, it prints out 3
// the size of the array, which is not the number of 'filled' elements inside
// I guess there is another method I don't know yet to count the amount of data units 
// contained in the array

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

// now let's try to ecceed the number of elements:
// this throws a runtime error
// fraudulentOrderIDs[3] = "D000";
// Console.WriteLine(fraudulentOrderIDs[3]);

// LOOPING!
/*
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
	Console.WriteLine(name);
}

int[] inventory = [ 200, 450, 700, 175, 250 ];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
	sum += items;
	bin++;
	Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/

string[] orderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];
foreach (string orderId in orderIDs)
{
	if (orderId.StartsWith("B"))
	{
		Console.WriteLine($"The order #{orderId} looks suspicious!");
	}
}
