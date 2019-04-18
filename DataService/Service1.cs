using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataEntityTier;

namespace DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public NorthwindDataSet.CustomersDataTable GetCustomers()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter
                 CustomersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            return CustomersTableAdapter1.GetCustomers();

        }
        public NorthwindDataSet.OrdersDataTable GetOrders()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter
                 OrdersTableAdapter1
                = new DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter();
            return OrdersTableAdapter1.GetOrders();

        }

        public NorthwindDataSet.ProductsDataTable GetProducts()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.ProductsTableAdapter
                productsTableAdapter1 = new DataAccessTier.NorthwindDataSetTableAdapters.ProductsTableAdapter();
                return productsTableAdapter1.GetProducts();
        }

        public NorthwindDataSet.Order_DetailsDataTable GetOrderDetails()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter
               order_DetailsTableAdapter1 = new DataAccessTier.NorthwindDataSetTableAdapters.Order_DetailsTableAdapter();
            return order_DetailsTableAdapter1.GetOrderDetails();
        }

        public NorthwindDataSet.CategoriesDataTable GetCategories()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.CategoriesTableAdapter
               categoriesTableAdapter1 = new DataAccessTier.NorthwindDataSetTableAdapters.CategoriesTableAdapter();
            return categoriesTableAdapter1.GetCategory();
        }

        public NorthwindDataSet.SuppliersDataTable GetSuppliersData()
        {
            DataAccessTier.NorthwindDataSetTableAdapters.SuppliersTableAdapter
            SuppliersTableAdapter1 = new DataAccessTier.NorthwindDataSetTableAdapters.SuppliersTableAdapter();
            return SuppliersTableAdapter1.GetSuppliers();
        }
    }
}
