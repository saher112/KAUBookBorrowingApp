using KAUBookBorrowingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAUBookBorrowingApp
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> books = new Dictionary<string, double>
{
    {"Engineering Economy (IE201)", 35.0},
    {"Thermodynamics (ME203)", 40.0},
    {"Electric Circuits (EE201)", 45.0},
    {"Statics (CE201)", 30.0},
    {"Introduction to Industrial Engineering (IE101)", 25.0},
    {"Linear Algebra (MATH204)", 20.0}
};

        public Form1()
        {
            InitializeComponent();

            // Fill the books list with engineering subjects
            lstBooks.Items.AddRange(books.Keys.ToArray());
        }


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            foreach (string selectedBook in lstBooks.SelectedItems)
            {
                double price = books[selectedBook];
                double total = price * quantity;
                lstCart.Items.Add($"{selectedBook} | Qty: {quantity} | Subtotal: {total} SAR");
            }

            MessageBox.Show("Books added to cart.");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (string item in lstCart.Items)
            {
                int lastColon = item.LastIndexOf(':');
                string subtotalString = item.Substring(lastColon + 1).Replace("SAR", "").Trim();
                double subtotal = double.Parse(subtotalString);
                total += subtotal;
            }

            bool isInKAU = LocationService.IsWithinKAURadius();
            double discount = isInKAU ? 0.20 : 0.0;
            double discountAmount = total * discount;
            double finalTotal = total - discountAmount;

            string resultText = $"Total before discount: {total} SAR\n" +
                                $"Discount: {discount * 100}% = {discountAmount} SAR\n" +
                                $" Final Total: {finalTotal} SAR\n" +
                                $"{(isInKAU ? "\n✅ Inside KAU (Discount Applied)" : "\n❌ Outside KAU (No Discount)")}";

            
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.SetSummary(resultText);
            summaryForm.ShowDialog();
        }


        private void btnTestLocation_Click(object sender, EventArgs e)
        {
            string json = LocationService.GetRawLocation();
            MessageBox.Show(json, "Your Current Location");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
