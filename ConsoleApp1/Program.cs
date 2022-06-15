// Calculator Program

int num1;
int num2;

// Display title
Console.WriteLine("Calculator Program");

Console.WriteLine("Type a number, and then hit Enter");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type another number, and then hit Enter");

num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");


// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = {(num1 + num2)}");
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = {(num1 - num2)}");
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = {(num1 * num2)}");
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = {(num1 / num2)}");
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();