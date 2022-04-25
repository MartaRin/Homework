using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Telephone
    {
        
        public Telephone()
        {

        }
                
        public Telephone(string brand, string model, int length, int height, int width)
        {
            Brand = brand;
            Model = model;
            Length = length;
            Height = height;
            Width = width;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public void AbleToCall()
        {

        }

        public void CanSendSms()
        {

        }

    }
}
