using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4226_Assignment2
{
    public partial class couponsFrm : Form
    {
        Form1 form1;
        public couponsFrm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }


        private void addtListBttn_Click(object sender, EventArgs e)
        {
            if(couponsListBox.SelectedIndex == -1) { return; }
            Console.WriteLine(couponsListBox.SelectedItem.ToString());

            String selectedItem = couponsListBox.SelectedItem.ToString();

            

            switch (selectedItem)
            {
                case "Milk (COUPON)":
                    form1.Add_Coupon_To_ShoppingList(Form1.Coupon.Milk);
                    break;

                case "Sugar (COUPON)":
                    form1.Add_Coupon_To_ShoppingList(Form1.Coupon.Sugar);
                    break;

                case "Coffee (COUPON)":
                    form1.Add_Coupon_To_ShoppingList(Form1.Coupon.Coffee);
                    break;

                default:

                    break;

            }


            this.Close();
        }

        private void couponsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
