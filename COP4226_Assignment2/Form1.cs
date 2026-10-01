/*
 * ‘Affirmation of Authorship:

‘Name: Stewart Smith Jr

‘Date: 09/27/2026

‘I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else, including Copilot. 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static COP4226_Assignment2.Form1;

namespace COP4226_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        couponsFrm couponsFrm;

        productsFrm productsFrm;

        containFrm containsFrm;

        aboutFrm aboutFrm;
        public enum Product
        {
           
            Bread,//3.95
            Milk,//4.5
            Sugar,//2.5
            Coffee//4.95
        }
        public enum Coupon
        {
          
            Milk,//-0.75
            Sugar,//-0.55
            Coffee//-1.85
        }

       
        List<(Product productItem, decimal productValue)> products = new List<(Product productItem, decimal productValue)>();
        List<(Coupon couponItem, decimal couponValue)> coupons = new List<(Coupon couponItem, decimal couponValue)>();

        decimal productTotal =0m;
        decimal couponTotal =0m;
        decimal taxTotal = 0;
        decimal deliveryTotal = 0;
        decimal total = 0;

        bool containsCoupon;
        bool containsProduct;
        private void shopMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void couponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            couponsFrm = new couponsFrm(this);

            couponsFrm.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productsFrm = new productsFrm(this);
            productsFrm.ShowDialog();
        }

        public void Add_Product_To_ShoppingList(Product product)
        {
            


            switch (product)
            {
                case Product.Bread:
                    shoppingLstListBox.Items.Add("Bread (PRODUCT)");
                    products.Add((Product.Bread, 3.95m));
                    break;
                case Product.Milk:
                    shoppingLstListBox.Items.Add(("Milk (PRODUCT)"));
                    products.Add((Product.Milk, 4.50m));
                    break;

                case Product.Sugar:
                    shoppingLstListBox.Items.Add(("Sugar (PRODUCT)"));
                    products.Add((Product.Sugar, 2.50m));
                    break;


                case Product.Coffee:
                    shoppingLstListBox.Items.Add(("Coffee (PRODUCT)"));
                    products.Add((Product.Coffee, 4.95m));
                    break;

            }

            Calculate_Product();
            Calculate_Coupons();
            Calculate_Total();
        }
        public void Add_Coupon_To_ShoppingList(Coupon coupon)
        {
           

            switch (coupon)
            {
                
                case Coupon.Milk:
                    shoppingLstListBox.Items.Add(("Milk (COUPON)"));
                    coupons.Add((Coupon.Milk, -1.75m));
                    break;

                case Coupon.Sugar:
                    shoppingLstListBox.Items.Add(("Sugar (COUPON)"));
                    coupons.Add((Coupon.Sugar, -0.55m));
                    break;


                case Coupon.Coffee:
                    shoppingLstListBox.Items.Add(("Coffee (COUPON)"));
                    coupons.Add((Coupon.Coffee, -1.85m));
                    break;

            }

            Calculate_Coupons();
           
            Calculate_Total();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoppingLstListBox.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate_Product()
        {
            productTotal = 0m;

            for (int i =0; i<products.Count; i++)
            {
                productTotal = productTotal + products[i].productValue;
            }
            productTxtBox.Text = $"${productTotal}";
            Calculate_Tax();
            Calculate_Delivery();

        }

        private void Calculate_Coupons()
        {
            couponTotal = 0m;
            for (int i=0; i<coupons.Count; i++)
            {
                couponTotal =couponTotal + coupons[i].couponValue;

            }
            couponsTxtBox.Text = $"(${couponTotal})";
            Calculate_Tax();
            Calculate_Delivery();
            
        }

        private void Calculate_Tax()
        {
            taxTotal = 0m;
            taxTotal = productTotal * 0.06m;

            taxTxtBox.Text = $"${taxTotal}";
        }

        private void Calculate_Delivery()
        {
            deliveryTotal = 0m;
            if (deliveryCheckBox.Checked) { 

                foreach((Product productItem, decimal productValue) product in products)
                {
                    deliveryTotal += 2m;
                }
            }
            else
            {
                deliveryTotal = 0;
            }

            shippingTxtBox.Text = $"${deliveryTotal}";
        }

        private void Calculate_Total()
        {
            total = 0m;
            total = productTotal + couponTotal + deliveryTotal + taxTotal;

            totalTxtBox.Text = $"${total}";
        }

        private void removeBttn_Click(object sender, EventArgs e)
        {
            if(shoppingLstListBox.SelectedIndex == -1) { return; }
            String selectedItemString = shoppingLstListBox.SelectedItem.ToString();

            int index = shoppingLstListBox.SelectedIndex;
           
            shoppingLstListBox.Items.Remove(shoppingLstListBox.SelectedItem);
            
            if (selectedItemString.Contains("COUPON"))
            {
                coupons.RemoveAt(index);
            }
            else if (selectedItemString.Contains("PRODUCT"))
            {
                products.RemoveAt(index);
            }
            Calculate_Product();
            Calculate_Coupons();
            Calculate_Total();
        }

        private void productTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deliveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Calculate_Delivery();
            Calculate_Total();
        }

        private void shoppingListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            containsCoupon = false;
            containsProduct = false;
            if(shoppingListComboBox.SelectedIndex == 0)
            {
                foreach (var item in shoppingLstListBox.Items)
                {
                    if (item.ToString().Contains("COUPON"))
                    {
                        containsCoupon = true;
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in shoppingLstListBox.Items)
                {
                    if (item.ToString().Contains("PRODUCT"))
                    {
                        containsProduct = true;
                        break;
                    }
                }
            }
            containsFrm = new containFrm(this);

            containsFrm.ShowDialog();

        }

        public String Get_Contains_Text()
        {
            if (shoppingListComboBox.SelectedIndex == 0)
            {
                if (containsCoupon)
                {
                    return "Contains (COUPON)";
                }
                else
                {
                    return "Does Not Contain (COUPON)";
                }

            }
            else
            {
                if (containsProduct)
                {
                    return "Conatins (PRODUCT)";
                }
                else
                {
                    return "Does Not Contain (PRODUCT)";
                }
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutFrm = new aboutFrm(this);

            aboutFrm.ShowDialog();
        }
    }
}


