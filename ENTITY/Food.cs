using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Food 
    {
        private string name;
        private double price;
        private string foodId;
        private string foodType;
        private MemoryStream memStream;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string FoodID
        {
            get { return foodId; }
            set { foodId = value; }
        }
        public string FoodType
        {
            get { return foodType; }
            set { foodType = value; }
        }
        public MemoryStream MemS
        {
            get { return memStream; }
            set { memStream = value; }
        }
    }
}
