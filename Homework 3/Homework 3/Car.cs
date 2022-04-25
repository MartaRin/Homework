
namespace Homework_3
{
    public class Car
    {
        public Car() 
        {
        
        }
        public Car(string brand, string numberPlate, string topSpeed)
        {
            Brand = brand;
            NumberPlate = numberPlate;
            TopSpeed = topSpeed;
        }

        public string Brand { get; set; }
        public string NumberPlate { get; set; }
        public string TopSpeed { get; set; }
       

        public string StartToDrive { get; set; }
        public string Accelerate { get; set; }
        public string StopDriving { get; set; }

        public void BeepBeep()
        {
            Console.WriteLine("Beep Beep");
        }
    }
}
