/*
// Lesson practice:

Random dice = new Random();
int rollDice()
{
    return dice.Next(1, 7);
}

int roll1 = rollDice();
int roll2 = rollDice();
int roll3 = rollDice();

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/

// Improve renewal rate of subscriptions challenge
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string message;

if (daysUntilExpiration == 0)
{
    message = "Your subscription has expired";
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    message = $"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    message = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!";
}
else if (daysUntilExpiration <= 10)
{
    message = "Your subscription will expire soon. Renew now!";
} else
{
    message = "";
}

Console.WriteLine(message);