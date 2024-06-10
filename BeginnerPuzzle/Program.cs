
static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("How many drugs you want to buy?: ");
    string? drugs = Console.ReadLine();

    // An integer "int" is any WHOLE number from -2,147,483,648 to 2,147,483,647
    // No decimal points like 1.5, 2.1, 3.0 etc

    // Parsing
    // It throws an error if you don't enter an integer
    // Be aware that if you do not enter a number that can be converted to an integer, the program will crash.
    // That's ok for now. We will cover if/else statements and null checks soon
    int numOfDrugs = int.Parse(drugs);

    Console.WriteLine($"This is a police sting operation, you are under arrest for buying {numOfDrugs} drugs. Naughty, Naughty!");

    // Another technique is Conversion
    // It will return 0 if the input is null
    int numOfDrugs2 = Convert.ToInt32(drugs);

    Console.WriteLine($"This is a police sting operation, you are under arrest for buying {numOfDrugs2} drugs. Naughty, Naughty!");
}


// Puzzle A - Maths Stuff
// 
// Write a program that asks the user to input two numbers
// Add the numbers together and display the result
// Subtract the second number from the first number and show the result
// Multiply the two numbers together and show the result
// Divide the first number by the second number. Show the answer - whole number AND the REMAINDER
// Divide the first number by the second number and get a fraction like 1.666  (look up divide cast to double)

static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Please enter a WHOLE number: ");
    string? numInput1 = Console.ReadLine();
    int num1 = int.Parse(numInput1);

    Console.WriteLine("Please enter another WHOLE number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    // Add
    int addResult = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {addResult}");

    // Subtract
    int subtractResult = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {subtractResult}");

    // Multiply
    int multiplyResult = num1 * num2;
    Console.WriteLine($"{num1} x {num2} = {multiplyResult}");

    // Divide
    int divideResult = num1 / num2;
    int remainder = num1 % num2;
    Console.WriteLine($"{num1} / {num2} = {divideResult} remainder {remainder}");

    double divideDouble = (double)num1 / num2;
    Console.WriteLine($"{num1} / {num2} = {divideDouble}");
}


static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Elon Musk is drunk again and he is giving away free money on social media");
    Console.WriteLine("How much free money do you want?:");
    string? moneyInput = Console.ReadLine();

    // float allows decimal points or "Floating points"
    // It fills up 4 bytes of memory (32-bit)
    // The number can be 7 decimal digits
    float money = float.Parse(moneyInput);
    float roundedMoney = (float)Math.Round(money, 2);     // We can only have 2 decimals after the floating point for cents. So round the value.

    Console.WriteLine($"Elon Musk sends you ${roundedMoney} by bank transfer");

    // Double allows decimal points or "Floating points"
    // It fills up 8 bytes of memory (64-bit)
    // The number can be 15 decimal digits
    double moneyDouble = double.Parse(moneyInput);
    double roundedMoneyDouble = Math.Round(money, 2);

    Console.WriteLine($"Elon Musk sends you ${roundedMoneyDouble} by paypal");
}


// Puzzle B - Money
//
// Decimal is usually used for money, not float or double. It's more accurate.
// Write a program that asks for donations to a charity
// Get the user's donation amount as a decimal
// Elon Musk will match the amount the user enters
// Output the user's donation amount, and the total donation after Elon matches it.

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("How much would you like to donate to Sex Addicts Anonymous?:");
    string? moneyInput = Console.ReadLine();

    decimal money = decimal.Parse(moneyInput);
    decimal roundedMoney = Math.Round(money, 2);

    decimal matchedTotal = roundedMoney * 2;

    Console.WriteLine($"You have donated ${roundedMoney} to Sex Addicts Anonymous, and Elon Musk has matched the donation!");
    Console.WriteLine($"Total Donated: ${matchedTotal}");

}


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Rolling the dice....");

    Random randy = new Random();
    int roll = randy.Next(1, 6);

    Console.WriteLine($"You rolled a {roll}");


}


// Puzzle C - Death and Taxes
// 
// Write a Tax Department program that asks the user to enter their yearly salary
// Randomly generate a percentage between 30% and 100% to tax them
// Calculate what they will pay in tax
// The tax department works using whole numbers, so if they enter a floating point number round it up to a whole number.
// Tell them the bad news. Let them know the tax percentage they are paying and how much they will pay in tax.
static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

    Console.WriteLine("Tax Department");
    Console.WriteLine("You must enter your yearly salary, or you will be arrested: ");
    string? salaryInput = Console.ReadLine();

    decimal salary = decimal.Parse(salaryInput);
    decimal roundedSalary = Math.Round(salary, 0);           // Tax dept usually just goes by whole numbers

    Random randy = new Random();
    int tax = randy.Next(30, 100);

    decimal taxToPay = roundedSalary * tax / 100;

    Console.WriteLine($"You need to pay {tax}% tax, that's ${taxToPay} you owe us or else");
}



// Run the puzzles

//ExampleA();
PuzzleA();

//ExampleB();
PuzzleB();

//ExampleC();
PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter
