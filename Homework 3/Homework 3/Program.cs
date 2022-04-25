
using Homework_3;
Console.WriteLine();
Console.WriteLine("=========1st task===========");
Console.WriteLine();

Telephone telephone = new Telephone();

Console.WriteLine("Please enter the brand of your phone:");
telephone.Brand = Console.ReadLine();
Console.WriteLine("Please enter the model of your phone:");
telephone.Model = Console.ReadLine();
Console.WriteLine("Please enter the length of your phone:");
string telephoneLengthString = Console.ReadLine();
int Length = int.Parse(telephoneLengthString);

Console.WriteLine("Please enter the width of your phone:");
string telephoneWidthString = Console.ReadLine();
int Width = int.Parse(telephoneWidthString);

Console.WriteLine("Please enter the height of your phone:");
string telephoneHeightString = Console.ReadLine();
int Height = int.Parse(telephoneHeightString);


Console.WriteLine();
Console.WriteLine("=========2nd task===========");
Console.WriteLine();

Car car = new Car();

Console.WriteLine("Please enter the brand of your car:");
car.Brand = Console.ReadLine();
Console.WriteLine("Please enter your car's full numberplate:");
car.NumberPlate = Console.ReadLine();
Console.WriteLine("Please enter your car's top speed:");
car.TopSpeed = Console.ReadLine();
car.BeepBeep();

Console.WriteLine();
Console.WriteLine("=========3rd task===========");
Console.WriteLine();

//Izmeginaju daudz ko, bet nesaprotu kapec atgriez 0 visas vertibas

Product product = new Product();

Console.WriteLine("Please enter the length of your product:");
string productLengthString = Console.ReadLine();
int ProductLength = int.Parse(productLengthString);

Console.WriteLine("Please enter the width of your product:");
string productWidthString = Console.ReadLine();
int ProductWidth = int.Parse(productWidthString);

Console.WriteLine("Please enter the height of your product:");
string productHeightString = Console.ReadLine();
int ProductHeight = int.Parse(productHeightString);

Console.WriteLine("Please enter the weight of your product:");
string productWeightString = Console.ReadLine();
int ProductWeight = int.Parse(productWeightString);

product.TheProduct();

Console.WriteLine();
Console.WriteLine("=========4th task===========");
Console.WriteLine();

Person person = new Person();

Console.WriteLine("Please enter your full name:");
person.FullName = Console.ReadLine();
Console.WriteLine("Please enter the date of your birth:");
string personDateOfBirth = Console.ReadLine();
DateTime dateOfBirth = DateTime.Now;

Console.WriteLine("Please enter your hobby:");
person.Hobby = Console.ReadLine();
Console.WriteLine("Please enter your gender:");
person.Gender = Console.ReadLine();

person.Greeting();