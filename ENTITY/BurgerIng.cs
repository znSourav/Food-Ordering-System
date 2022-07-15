using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class BurgerIng
    {
        private double cost;
        private List<string> Ingredients;
        private Dictionary<string, double> price;
        private Dictionary<string, int> quantity;

        public BurgerIng()
        {
            this.cost = 0;
            Ingredients = new List<string>();
            price = new Dictionary<string, double>();
            quantity = new Dictionary<string, int>();
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public List<string> Ing
        {
            get { return Ingredients; }
            set { Ingredients = value; }
        }

        public Dictionary<string, double> Price
        {
            get { return price; }
            set { price = value; }
        }

        public Dictionary<string, int> Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public void AddStuff(string ing, double pi)
        {
            foreach (string x in Ingredients)
            {
                if (x.Equals(ing))
                {
                    quantity[ing]++;
                    cost += pi;
                    return;
                }
            }
            Ingredients.Add(ing);
            quantity[ing] = 1;
            price[ing] = pi;
            cost += pi;
        }
        
        public void RemoveStuff(string ing, double pi)
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                if (Ingredients[i].Equals(ing))
                {
                    quantity[ing]--;
                    if (quantity[ing] == 0)
                    {
                        Ingredients.RemoveAt(i);
                    }
                    cost -= pi;
                    return;
                }
            }
        }

        public void Clear()
        {
            cost = 0;
            price.Clear();
            quantity.Clear();
            Ingredients.Clear();
        }
    }
}
