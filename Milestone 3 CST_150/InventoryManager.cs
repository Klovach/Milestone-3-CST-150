using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3_CST_150
{
    internal class InventoryManager
    {
        // List collection
        List<Product> inventoryList = new List<Product>();


        // Add() 
        /* Add new product to list. */
        public void add(Product product)
        {
            inventoryList.Add(product);
        }

        // addProduct()
        /* Here we create a  new product and add the product to the list.*/
        public void addProduct(string name, double price, int quantity)
        {
            Product i = new Product(name, price, quantity); 
            inventoryList.Add(i);
            MessageBox.Show("You added a product to your inventory.");
        }


        // Display a product 
        /* Here we utilize a string builder to create a new string.
         Our string is constructed of every item in our inventoryList.
         In addition to the items, a border is added at the end of every item.*/
        public string displayProducts()
        {
            var sb = new StringBuilder(); 
            foreach (Product i in inventoryList)
            {
                string str = i.ToString() + "\n";
                string border = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n";
                sb.Append(str + border); 
            }
            return sb.ToString();

        }

        // Remove a product
        /* Here we use a for loop to scan the inventory. Then, we check whether the input
         is equal to the current product's name or not. If we find the product, we remove
        the product on that index. */
        public void removeProduct(string n)
        {
            int flag = 0;

            for (int i = 0; i < inventoryList.Count; i++)
            {
                if (inventoryList[i].Name.Equals(n)) 
                {
                    inventoryList.RemoveAt(i); 
                    MessageBox.Show("Product removed");
                    flag = 1;
                }
            }

            if (flag == 0)
                MessageBox.Show("Product not found");

        }

        //Search by the name. 
        /* Here we use a for loop to scan the inventory. Then, we check whether the input
         is equal to the current product's name or not. If we find the product, we display
        the product on that index.*/
        public void searchProductByName(string queryName)
        {

            int flag = 0;

            foreach (Product i in inventoryList)
            {
                if (i.Name.Equals(queryName))
                {
                    MessageBox.Show(i.ToString());
                    flag = 1;
                }

            }

            if (flag == 0)
                MessageBox.Show("Product not found");

        }

        //Search by the price. 
        /* Here we use a for loop to scan the inventory. Then, we check whether the input
         is equal to the current product's price or not. If we find the product, we display
        the product on that index.*/
        public void searchProductByPrice(double queryPrice)
        {

            int flag = 0;

            foreach (Product i in inventoryList)
            {

                if (i.Price == queryPrice)
                {
                    MessageBox.Show(i.ToString());
                    flag = 1;
                }

            }

            if (flag == 0)
                MessageBox.Show("Product not found");

        }


        // Restock Product
        /* Here we use a for loop to scan the inventory. Then, we check whether the input
         is equal to the current product's name or not. If we find the product, we change
        that product's quantity on that index.*/
        public void restockProduct(string name, int quantity)
        {
            foreach (Product i in inventoryList)
            {
                if (i.Name.Equals(name)) 
                {
                    i.Quantity = quantity; 
                    MessageBox.Show("You updated the quantity of this item!");
                }

            }

        }

    }
}