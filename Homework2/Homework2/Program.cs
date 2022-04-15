
Console.WriteLine("=========1st task===========");
Console.WriteLine();

Console.WriteLine("Enter your name");
string userName = Console.ReadLine();
Console.WriteLine("Hello " + userName);

Console.WriteLine();
Console.WriteLine("=========2nd task===========");
Console.WriteLine();

Console.WriteLine("How old are you?");
string userAgeString = Console.ReadLine();
int userAge = int.Parse(userAgeString);
int byOneLarger = userAge + 1;
Console.WriteLine("Next year you will be " + byOneLarger + ". You are of age.");

Console.WriteLine();
Console.WriteLine("=========3rd task===========");
Console.WriteLine();

Console.WriteLine("Enter a digit");
string firstNumberString = Console.ReadLine();
Console.WriteLine("Enter a second digit");
string secondNumberString = Console.ReadLine();

int firstNumber = int.Parse(firstNumberString);
int secondNumber = int.Parse(secondNumberString);

int largerNumber = Math.Max(firstNumber, secondNumber);

Console.WriteLine("The larger number is " + largerNumber);

Console.WriteLine();
Console.WriteLine("=========4th task===========");
Console.WriteLine();

Console.WriteLine("Enter a digit");
string smallerNumberString = Console.ReadLine();
Console.WriteLine("Enter a second digit");
string secondSmallerNumberString = Console.ReadLine();

int firstSmallerNumber = int.Parse(smallerNumberString);
int secondSmallerNumber = int.Parse(secondSmallerNumberString);

int smallerNumber = Math.Min(firstSmallerNumber, secondSmallerNumber);

Console.WriteLine("The smaller number is " + smallerNumber);

Console.WriteLine();
Console.WriteLine("=========5th task===========");
Console.WriteLine();

Console.WriteLine("Enter a digit");
string divisionNumberString = Console.ReadLine();
Console.WriteLine("Enter a second digit");
string secondDivisionNumberString = Console.ReadLine();

int divisionNumber = int.Parse(divisionNumberString);
int secondDivisionNumber = int.Parse(secondDivisionNumberString);

divisionNumber %= secondDivisionNumber;
Console.WriteLine("The remaineder from the division is " + divisionNumber);

Console.WriteLine();
Console.WriteLine("=========6th task===========");
Console.WriteLine();

Console.WriteLine("Enter a digit");
string OddEvenNumberString = Console.ReadLine();

int OddEvenNumber = int.Parse(OddEvenNumberString);

if (OddEvenNumber % 2 == 0) { Console.WriteLine(OddEvenNumber + " is an even number"); }
else { Console.WriteLine(OddEvenNumber + " is an odd number"); }

Console.WriteLine();
Console.WriteLine("=========7th task===========");
Console.WriteLine();

Console.WriteLine("Enter the height of the rectangle");
string heightString = Console.ReadLine();
Console.WriteLine("Enter the length of the rectangle");
string lengthString = Console.ReadLine();

double length = double.Parse(lengthString);
double height = double.Parse(heightString);

double area = length * height;
double rounded = Math.Round(area, 2);

Console.WriteLine("The area of the rectangle is " + rounded);

Console.WriteLine();
Console.WriteLine("=========8th task===========");
Console.WriteLine();

Console.WriteLine("Enter the length of two of the sides of a right-angle icosolese triangle");
string sideString = Console.ReadLine();

double side = double.Parse(sideString);
double areaOfTriangle = (side * side / 2);

Console.WriteLine("Area of the right-angle icosolese triangle is " + areaOfTriangle);

Console.WriteLine();
Console.WriteLine("=========9th task===========");
Console.WriteLine();

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("How old are you?");
string age = Console.ReadLine();

string formattedMessage = $"Hello {name}! You are {age} years old";

Console.WriteLine(formattedMessage);
