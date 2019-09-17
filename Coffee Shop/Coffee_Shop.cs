using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
    
        int i = 0;
        string[] customerName = new string[100];
        string[] contactNo = new string[100];
        string[] address = new string[100];
        string[] order = new string[100];
        string[] quantity = new string[100];
        int[] quantity1= new int[100];
        int[] price = new int[100];
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (customernameTextBox.Text == "" || contactnoTextBox.Text == "" || addressTextBox.Text == "" ||
                orderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                if (customernameTextBox.Text == "" && contactnoTextBox.Text == "" && addressTextBox.Text == "" &&
                    orderComboBox.Text == "" && quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please enter all customer information");
                }
                else if (customernameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a customer name");
                }
                else if (contactnoTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a customer no");
                }
                else if (addressTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a address");
                }
                else if (orderComboBox.Text == "")
                {
                    MessageBox.Show("Please enter a order");
                }
                else if (quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a quantity");
                }
                else
                {
                    MessageBox.Show("Please enter all customer information");
                }

                
            }
            else
            {
                customerName[i] = customernameTextBox.Text;
                contactNo[i] = contactnoTextBox.Text;
                address[i] = addressTextBox.Text;
                order[i] = orderComboBox.Text;
                quantity[i] = quantityTextBox.Text;

                quantity1[i] = Convert.ToInt32(Quantity[i]);

                if (orderComboBox.Text == "Black")
                {
                    price[i] = quantity1[i] * 120;
                    MessageBox.Show("The bill is " + price[i] + "Tk.");
                }
                else if (orderComboBox.Text == "Cold")
                {
                    price[i] = quantity1[i] * 100;
                    MessageBox.Show("The bill is " + price[i] + "Tk.");
                }
                else if (orderComboBox.Text == "Hot")
                {
                    price[i] = quantity1[i] * 90;
                    MessageBox.Show("The bill is " + price[i] + "Tk.");
                }
                else if (orderComboBox.Text == "Regular")
                {
                    price[i] = quantity1[i] * 80;
                    MessageBox.Show("The bill is " + price[i] + "Tk.");
                }
                else
                {
                    MessageBox.Show("Please enter a order");
                }
                

                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + customerName[i];
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + contactNo[i];
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Address             :" + address[i];
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + order[i];
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity[i];
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Price                 :" + price[i] + "Tk.";
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + "";

                MessageBox.Show("Successfully Saved");

                customernameTextBox.Text = "";
                contactnoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";
                i++;
            }

        }
    }
}
