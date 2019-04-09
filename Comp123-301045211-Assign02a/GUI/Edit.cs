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
		Home home1;

		public Edit(Home home, Customer customer)
		{
			InitializeComponent();
			home1 = home;
			this.editableCustomer = customer;
			txtName.Text = customer.Name;
			txtStreet.Text = customer.Address.Street.ToString();
			txtCity.Text = customer.Address.City.ToString();
			txtProvince.Text = customer.Address.Province.ToString();
			txtPostal.Text = customer.Address.PostalCode.ToString();
			txtPhone.Text = customer.Phone.ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//String customerName = txtName.Text;
			Customer editableCustomer;
			foreach (var customer in home1.repository.Customers)
			{
				editableCustomer = customer;
				editableCustomer.Name = txtName.Text;
				editableCustomer.Phone = Convert.ToInt64(txtPhone.Text);
				Address Address1;
				Address1.Street = txtStreet.Text;
				Address1.City = txtCity.Text;
				Address1.Province = txtProvince.Text;
				Address1.PostalCode = txtPostal.Text;
				editableCustomer.Address = Address1;
				home1.PopulateListBox();
				this.Close();
			}
		}
	}
}