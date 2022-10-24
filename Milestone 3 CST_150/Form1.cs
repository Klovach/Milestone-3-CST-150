using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3_CST_150
{
    public partial class Form1 : Form
    {
        InventoryManager inventory = new InventoryManager();
        public Form1()
        {
            InitializeComponent();
            // Create Products
            Product White_Bread = new Product("White Bread", 3.99, 50);
            Product Wheat_Bread = new Product("Wheat Bread", 3.99, 50);
            Product Rye_Bread = new Product("Rye Bread", 6.99, 60);
            Product Sourdough_Bread = new Product("Sourdough Bread", 6.99, 28);
            Product Multigrain_Bread = new Product("Multigrain Bread", 5.99, 40);
            Product Pita_Bread = new Product("Pita Bread", 4.99, 50);
            Product Brioche = new Product("Brioche", 4.99, 34);
            Product Bagels = new Product("Bagels", 5.99, 53);
            Product Focaccia = new Product("Focaccia", 6.99, 23);
            Product Ciabatta = new Product("Ciabatta", 4.99, 32);

            // Add Products To Inventory
            inventory.add(White_Bread);
            inventory.add(Wheat_Bread);
            inventory.add(Rye_Bread);
            inventory.add(Sourdough_Bread);
            inventory.add(Multigrain_Bread);
            inventory.add(Pita_Bread);
            inventory.add(Brioche);
            inventory.add(Bagels);
            inventory.add(Focaccia);
            inventory.add(Ciabatta);

            // Display 
            txtDisplay.Text += inventory.displayProducts(); 
        }

        // Add New Item 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            double price;
            int quantity;
            try
            {
                name = txtNewName.Text;
                price = (Convert.ToDouble(txtNewPrice.Text));
                quantity = (Convert.ToInt32(txtNewQuantity.Text));
                inventory.addProduct(name, price, quantity);
                txtDisplay.Text = inventory.displayProducts();
            }
            catch
            {
                MessageBox.Show("Please enter a valid name, quantity, and unit price!");
            }
        }

        // Clear The Interface
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchByName.Clear();
            txtSearchByPrice.Clear();
            txtRestockName.Clear();
            txtRestockNum.Clear(); 
            txtDelete.Clear();
            txtNewName.Clear();
            txtNewQuantity.Clear();
            txtNewPrice.Clear();
            txtSearchByName.Focus(); 
        }


        // Search By Price
        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            double queryPrice;
            try
            {
                if (txtSearchByPrice.Text != "")
                {
                    queryPrice = (Convert.ToDouble(txtSearchByPrice.Text));
                    inventory.searchProductByPrice(queryPrice);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid price!");
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string queryName;
            if (txtSearchByName.Text != "")
            {
                queryName = txtSearchByName.Text.ToString();
                inventory.searchProductByName(queryName);
            }
            else
            {
                MessageBox.Show("Please enter a valid name!");
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            string name;
            int quantity;
            try
            {
                name = txtRestockName.Text;
                quantity = Convert.ToInt32(txtRestockNum.Text);
                inventory.restockProduct(name, quantity);
                txtDisplay.Text = inventory.displayProducts();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number and name!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name;
            name = txtDelete.Text;
            inventory.removeProduct(name);
            txtDisplay.Text = inventory.displayProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
