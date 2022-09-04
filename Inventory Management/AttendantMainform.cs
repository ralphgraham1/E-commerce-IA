using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class AttendantMainform : Form
    {
        private string cs = "server=localhost;uid=root;pwd=;database='shoprite db'";
        private string sqlStatement = "SELECT * FROM products WHERE barcode LIKE '{barcode}'";


        private static ArrayList Barcode = new ArrayList();
        private static ArrayList ProductName = new ArrayList();
        private static ArrayList ProductDescription = new ArrayList();
        private static ArrayList CategoryID = new ArrayList();
        private static ArrayList Quantity = new ArrayList();
        private static ArrayList SellingPrice = new ArrayList();

        public AttendantMainform()
        {
            InitializeComponent();
        }
        public void AddToCart(string barcode, int quantity)
        {
            

                int i = 0;
                try
                {

                   MySqlConnection con = new MySqlConnection(cs);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM products WHERE barcode LIKE '{barcode}'", con);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        //the value of the quantity in the database in reader[4]
                        //the unit price of each product is given by the reader[5]


                        i++;
                        //updating the list that stores the product details
                        Barcode.Add(reader[0].ToString());
                        ProductName.Add(reader[1].ToString());
                        ProductDescription.Add(reader[2].ToString());
                        CategoryID.Add(reader[3].ToString());
                        Quantity.Add(quantity);
                        SellingPrice.Add((int)reader[5] * quantity);


                    }
                    reader.Close();
                    con.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                UpdateCartDataGrid();
            

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendantMainform_Load(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = textBarcode.Text;
            int quantity = (int)textQuantity.Value;

        }
        public void UpdateCartDataGrid()
        {
            dataGridCart.Rows.Clear();

            for (int i = 0; i < Barcode.Count; i++)
            {

                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridCart);
                newRow.Cells[0].Value = (i + 1).ToString();
                newRow.Cells[1].Value = Barcode[i];
                newRow.Cells[2].Value = ProductName[i];
                newRow.Cells[3].Value = ProductDescription[i];
                newRow.Cells[4].Value = CategoryID[i];
                newRow.Cells[5].Value = Quantity[i];
                newRow.Cells[6].Value = SellingPrice[i];
                dataGridCart.Rows.Add(newRow);
            }
        }
    }
}
