using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1 
{

    class Guest : IComparable
    {

        private string name;
        private double funds;

        public Guest(string name, double funds)
        {
            this.name = name;
            this.funds = funds;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Funds
        {
            get { return funds; }
            set { funds = value; }
        }

        public int CompareTo(object obj)
        {
            Guest other = (Guest)obj;
            return Name.CompareTo(other.Name);
        }


    }
}
