//Exercise 1.1: Echo String

Console.WriteLine("Please enter your name!");
Console.WriteLine(Console.ReadLine());
Console.WriteLine();

//Exercise 1.2 Adding a number to an integer 

Console.Write("Please enter a number: ");
int userNumber = int.Parse(Console.ReadLine());
Console.WriteLine(userNumber + 1);
Console.WriteLine();

//Exercise 1.3 Adding a number to a float 

Console.Write("Please enter a number: ");
float number = float.Parse(Console.ReadLine());
Console.WriteLine(number + .5);
Console.WriteLine();

//Exercise 1.4 Adding Two Floats 
Console.Write("Enter a number: ");
float numberOne = float.Parse(Console.ReadLine());
Console.Write("Enter another number: ");
float numberTwo = float.Parse(Console.ReadLine());
Console.WriteLine("The sum is " + (numberOne + numberTwo));
Console.WriteLine();

//Exercise 1.5: Multiplying Floats
Console.Write("Enter a number: ");
float firstNumber = float.Parse(Console.ReadLine());
Console.Write("Enter another number: ");
float secondNumber = float.Parse(Console.ReadLine());
Console.WriteLine("The product is " + (firstNumber * secondNumber));
Console.WriteLine();

//Exercise 1.6: Dividing integers
Console.Write("Enter a number: ");
int dividingNumber1 = int.Parse(Console.ReadLine()); // returns an exception if the number entered doesn't fit in
Console.Write("Enter another number: ");
int dividingNumber2 = int.Parse(Console.ReadLine());
Console.WriteLine("The result is " + (dividingNumber1 / dividingNumber2));
Console.WriteLine();

//Exercise 1.7: Entering booleans 
Console.Write("Enter a boolean: ");
bool userBool = bool.Parse(Console.ReadLine());
Console.WriteLine("You entered: " + userBool);
Console.WriteLine("The opposite of what you entered is: " + !userBool);
Console.WriteLine();

Console.ReadKey();







