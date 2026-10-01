using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4226_Assignment2
{
    public partial class productsFrm : Form
    {
        Form1 form;
        public productsFrm(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void addToListBttn_Click(object sender, EventArgs e)
        {

            if(productsListBox.SelectedIndex == -1) {return; }
            Console.WriteLine(productsListBox.SelectedItem.ToString());

            String selectedItem = productsListBox.SelectedItem.ToString();


            switch (selectedItem)
            {
                case "Bread (PRODUCT)":

                    form.Add_Product_To_ShoppingList(Form1.Product.Bread);
                    break;

                case "Milk (PRODUCT)":
                    form.Add_Product_To_ShoppingList(Form1.Product.Milk);
                    break;

                case "Sugar (PRODUCT)":
                    form.Add_Product_To_ShoppingList(Form1.Product.Sugar);
                    break;

                case "Coffee (PRODUCT)":
                    form.Add_Product_To_ShoppingList(Form1.Product.Coffee);
                    break;

                default:

                    break;

            }




            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
