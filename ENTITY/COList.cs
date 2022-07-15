using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class COList
    {
        private Food food;
        private int quantity = 0;

        public COList(Food food, int quantity)
        {
            this.food = food;
            this.quantity = quantity;
        }

        public Food COFood
        {
            get { return food; }
            set { food = value; }
        }

        public int COQuantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
