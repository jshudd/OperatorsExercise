
int a = 17;
int b = 4;

//Addition
int sum = a + b;
Console.WriteLine($"a + b = {sum}");

//Subtraction
int diff = a - b;
Console.WriteLine($"a - b = {diff}");

//Multiplication
int product = a * b;
Console.WriteLine($"a * b = {product}");

//Division
double quotient = Convert.ToDouble(a) / Convert.ToDouble(b);
Console.WriteLine($"a / b = {quotient}");

//Modulus
int remainder = a % b;
Console.WriteLine($"The remainder is {remainder}");

Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
Console.WriteLine();

//Exercise 2
Console.WriteLine("What is the radius of the circle?");
var radius = double.Parse(Console.ReadLine());

var circle = Math.PI* Math.Pow(radius, 2);

Console.WriteLine($"The area of the circle is {circle}");