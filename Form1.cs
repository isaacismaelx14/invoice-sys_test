using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double defaultInitPrice = 0.00; // Value that will appear in first load in labels: total and subtotal
        private int defaultProductCount = 1;
        private Invoice invoice = new Invoice(); 
        public Form1()
        {
            InitializeComponent();
            InitLabels();
            GenerateInvoiceId();
        }

        private void FindProduct()
        {
            int id = Convert.ToInt32(tbProductId.Text);
            // Get product info from data base with the ID from database...

            string product = "test product";    //Save product name
            double price = 300.99;              //Save product price
            AddProduct(product, price);
        }

        private void FindClient()
        {
            int id = Convert.ToInt32(tbClientID.Text);
            //Get Client info from data base with the ID from database...

            string name = "some client";    // Save Client name
            tbClientName.Text = name;
            invoice.ClientId = id;
        }
        private void SaveInvoice()
        {
            int clientId = invoice.ClientId;
            double total = invoice.Total;
            DateTime date = invoice.date;

            //Save the invoce in your data base here... 

            //You must remove the next line!
            MessageBox.Show("Cliente: " + clientId.ToString() + "\nTotal: " + total.ToString("00.00") + "\nFecha: " + date);
        }

        private void GenerateInvoiceId()
        {
            //Do query to get all invoice id and save the id in "lastValue"
            int lastValue = 0;
            tbInvoiceId.Text = Convert.ToString(lastValue++);
        }

        private void ResetAddProduct()
        {
            tbProductCount.Value = defaultProductCount;
            tbProductId.Text = "";
        }
        private void InitLabels()
        {
            lbTotal.Text = defaultInitPrice.ToString("00.00");
            tbProductCount.Value = defaultProductCount;
        }

        private void AddProduct(string product, double price)
        {
            int count = Convert.ToInt32(tbProductCount.Value);
            double total = price * count;

            string strTotal = total.ToString("00.00");
            string strPrice = price.ToString("00.00");

            dgvInvoiceData.Rows.Add(count, product, strPrice, strTotal);
            lbTotal.Text = GetTotal().ToString("00.00");
        }

        private double GetTotal()
        {
            double subTotal = 0;
            if (dgvInvoiceData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvInvoiceData.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if(cell.ColumnIndex == 3)
                        {
                            subTotal += Convert.ToDouble(cell.Value);
                            invoice.Total = subTotal;
                        }
                    }
                }

            }

            return subTotal;
        }

        void clearAll()
        {
            InitLabels();
            ResetAddProduct();
            tbClientName.Text = "";
            tbClientID.Text = "";
            dgvInvoiceData.Rows.Clear();
            GenerateInvoiceId();
        }

        private void tbProductCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FindProduct();
            ResetAddProduct();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            invoice.date = DateTime.Now;
            SaveInvoice();
            clearAll();
        }

        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            FindClient();
        }
    }

    class Invoice 
    {
        public int ClientId;
        public double Total;
        public DateTime date;
    }
}
