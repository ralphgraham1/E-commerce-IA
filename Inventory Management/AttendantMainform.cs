using System;
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
        public AttendantMainform()
        {
            InitializeComponent();
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
    }
}
