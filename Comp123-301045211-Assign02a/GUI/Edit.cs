using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopClassLibrary;

namespace CoffeShop.GUI
{
	public partial class Edit : Form
	{
		Customer editableCustomer;
		Home home;

		public Edit(Customer customer)
		{
			InitializeComponent();
			editableCustomer = customer;
			Customer selectCustomer;
			foreach (var cust in home.repository.Customers)
			{
				if (editableCustomer == cust.IdNumber)
				{
					selectCustomer = cust;
					txtName.Text = selectCustomer.Name;
					txtStreet.Text = selectCustomer.Address.Street.ToString();
					txtCity.Text = selectCustomer.Address.City.ToString();
					txtProvince.Text = selectCustomer.Address.Province.ToString();
					txtPostal.Text = selectCustomer.Address.PostalCode.ToString();
					txtPhone.Text = selectCustomer.Phone.ToString();
				}
				else
				{

				}
			}


		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			/*Home = form;
			
			int customerID = ( as Customer).IdNumber;
			Customer selectedCustomer;
			foreach (var customer in Home.repository.Customers)
			{
				if (customerID == customer.IdNumber)
				{
					selectedCustomer = customer;
					txtName.Text = selectedCustomer.Name;
					txtPhone.Text = (selectedCustomer.Phone).ToString();
					txtStreet.Text = selectedCustomer.Address.Street;
					txtCity.Text = selectedCustomer.Address.City;
					txtProvince.Text = selectedCustomer.Address.Province;
					txtPostal.Text = selectedCustomer.Address.PostalCode;
				}
				else
				{

				}
			}*/
		}
	}
}