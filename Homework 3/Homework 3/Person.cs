
namespace Homework_3
{
    public class Person
    {
        public Person()
        {
        
        }

        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }

        public void Hello()
        {

        }

        public int Age()
        {
        return DateTime.Now.Year - DateOfBirth.Year;

        }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is {FullName} and I am {Age} years old");
        }

    }
}
