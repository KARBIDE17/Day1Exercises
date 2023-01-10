
//Exercise 1 - Prompt the user to enter a string. After the user enters a string, output the same string back to the console.
using System.Runtime.CompilerServices;

Console.WriteLine("Enter some text:");
string input1 =Console.ReadLine();
Console.WriteLine(input1);

//Exercise 2 - Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.

Console.WriteLine("Enter a number:");
string input2 = Console.ReadLine();
int input2Parse = int.Parse(input2);
Console.WriteLine(input2Parse +1);

//Exercise 3 - Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.
Console.WriteLine("Enter a number again:");
string input3 = Console.ReadLine();
double input3Parse = double.Parse(input3);
Console.WriteLine(input3Parse + 0.5);

//Exercise 4 Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.
Console.WriteLine("Please enter two numbers");
Console.WriteLine("First number:");
string input4 = Console.ReadLine();
Console.WriteLine("Second number");
string input5 = Console.ReadLine();

double num1 = double.Parse(input4);
double num2 = double.Parse(input5);
double sum1 = num1 + num2;
Console.WriteLine(sum1);

//Exercise 5 Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.
Console.WriteLine("Please enter two numbers");
Console.WriteLine("First number:");
string input6 = Console.ReadLine();
Console.WriteLine("Second number");
string input7 = Console.ReadLine();

double num3 = double.Parse(input6);
double num4 = double.Parse(input7);
double sum2 = num3 * num4;
Console.WriteLine(sum2);









