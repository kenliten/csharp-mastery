// a simple recap for method calling:
// To call a method, you:
// 1 - Write the name of the class that contains the method
// 2 - Add the member access operator (the `.` symbol)
// 3 - Write the method name
// 4 - Add the method invocation operator (a set of parentheses), and
// 5 - Specify the parameters that will be passed to the method if any
// For example, in Console.WriteLine("Hello, World!");
// We are accesing the Console class, asking for the WriteLine member (method),
// invoking it by opening and closing parentheses and passing a string "Hello, World!"
// as a parameter

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine($"This roll gave you a {roll}");

// Exercise: Find a method of the System.Math class that returns the larger of two numbers.

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
