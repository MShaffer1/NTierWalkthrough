using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresenttaionTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service1.Service1Client DataSvc =
                new Service1.Service1Client();
            northwindDataSet.Customers.Merge(DataSvc.GetCustomers());
            northwindDataSet.Orders.Merge(DataSvc.GetOrders());
            northwindDataSet.Products.Merge(DataSvc.GetProducts());
            northwindDataSet.Categories.Merge(DataSvc.GetCategories());
            northwindDataSet.Order_Details.Merge(DataSvc.GetOrderDetails());
            northwindDataSet.Suppliers.Merge(DataSvc.GetSuppliersData());

        }

        private void ordersDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
