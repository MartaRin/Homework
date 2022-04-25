
namespace Homework_3
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int length, int height, int width, int weight)
        {
            Length = length;
            Height = height;
            Width = width;
            Weight = weight;
        }

        private int _length;
        private int _height;
        private int _width;
        public int Weight;

        public int Length
        {
            get
            {
                return _length;
            }

            set
            {
                Length = value;
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                Height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                Width = value;
            }
        }
        public int weight
        {
            get
            {
                return Weight;
            }

            set
            {
                Weight = weight;
            }
        }
        public string MakingTheProduct { get; set; }

        public void TheProduct()
        {
            Console.WriteLine($"Look at this product it is {Length} long, {Height} tall, {Width} wide and weights {weight}");
        }
    }
}
