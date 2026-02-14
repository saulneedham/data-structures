using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ADSPortEx3
{

    class Item : IComparable
    {
        private string name;
        private int val;
        private double weight;

        public Item(string name, int value, double weight)
        {
            Name = name;
            Value = value; //integer between 1 and 10
            Weight = weight;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Value
        {
            get { return val; }
            set { val = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double ValRatio
        {
            get { return (double)val / weight; }
        }

        public int CompareTo(object obj)
        {
            Item itemToCompare = obj as Item;
            if (this.ValRatio > itemToCompare.ValRatio)
                return -1; 
            else if (this.ValRatio < itemToCompare.ValRatio)
                return 1;
            else
                return 0;
        }
    }
}
