

//Exercise 1:
//Create a simple program named OperatorExercise in your repos folder to write
//out the results of addition, subtraction, multiplication, division, and
//modulus operations.

using Operators_Exercise;

var x = 10;
var y = 23;

x += y;
x -= y;
x *= y;
x /= y;
x %= y;

//For division, create two integer variables called a and b.
//Create a third integer variable and name it quotient (the result of a division)
//that stores the result of the division of a and b,
//and another integer variable named remainder that stores the remainder
//(using the % operator).
//Write out the results using Console.WriteLine or Console.Write to write out the
//results in the following form: if a = 17 and b = 4, print the following:
//The result should say: 17 / 4 is 4 remainder 1

int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;
Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

//Exercise 2:
//Create a method that will Calculate the area of a circle based on its radius -
//you can name the method AreaOfCircle.
//This method will use this formula Math.PI * Math.Pow(r, 2) and return the area of
//type double
//The method will also accept r as a parameter
//Allow a user to input a value for r in the console using the following code:
//var radius = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the radius");  
var userInput = double.Parse(Console.ReadLine());

var answer = Calculations.AreaOfCircle(userInput);
Console.WriteLine(answer);


