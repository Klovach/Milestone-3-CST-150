using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3_CST_150
{
    internal class Product
    {
        //INSTANCE VARIABLES
        string name;
        double price;
        int quantity;

        //Product Constructor 
        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;  
            this.quantity = quantity;
        }


        //GETTERS AND SETTERS
        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        // Override ToString() 
        public override string ToString()
        {
            return "Product Name: " + name + "\n Unit Price: " + price + "\n Quantity: " + quantity;
        }

    }
}
