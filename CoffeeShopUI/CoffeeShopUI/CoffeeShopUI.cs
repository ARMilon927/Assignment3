using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopUI
{
    public partial class CoffeeShopUI : Form
    {
        public CoffeeShopUI()
        {
            InitializeComponent();
        }

        private const int size = 100;
        private string[] customerName = new string[size];
        private string[] contactNumber = new string[size];
        private string[] customerAddress = new string[size];
        private string[] coffeeOrder = new string[size];
        private int[] price = new int[size];
        private int[] quantity = new int[size];
        private string purchase = "\t\tPurchase Information\n\n\n";

        private string message;
        //string[] customerPurchaseInformation = new string[10];
        private int index = 0;

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text == "" || contactTextBox.Text == "" || addressTextBox.Text == "" || orderComboBox.Text == "" ||
                quantityTextBox.Text == "")
            {
                MessageBox.Show("Please fill every field");
            }
            else
            {
                customerName[index] = nameTextBox.Text;
                contactNumber[index] = contactTextBox.Text;
                customerAddress[index] = addressTextBox.Text;
                coffeeOrder[index] = orderComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                if (orderComboBox.Text == "Black")
                    price[index] = 120;
                else if (orderComboBox.Text == "Cold")
                    price[index] = 100;
                else if (orderComboBox.Text == "Hot")
                    price[index] = 90;
                else
                    price[index] = 80;


                message = "\t\tCustomer No : " + Convert.ToInt16(index+1) + "\n\n";
                message = message + "Customer Name \t: " + customerName[index] + "\n";
                message = message + "Contact No \t\t: " + contactNumber[index] + "\n";
                message = message + "Address \t\t: " + customerAddress[index] + "\n";
                message = message + "Coffee ordered \t: " + coffeeOrder[index] + "\n";
                message = message + "Price per item \t\t: " + price[index] + "\n";
                message = message + "Quantity \t\t: " + quantity[index] + "\n\n";

                message = message + customerName[index] + " sir, you have to pay " + price[index] * quantity[index] + " Taka" + "\n\n";

                MessageBox.Show("Purchase successful.");
                
                    purchaseInformationRichTextBox.Text += message;
                
                
                index++;
            }
        }
    }
}
