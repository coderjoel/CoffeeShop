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
		private Home Home;

		public Edit(Home form)
		{
			InitializeComponent();
			Home = form;
			Customer editableCustomer = new Customer(); 
			txtName.Text = editableCustomer.Name;
			txtStreet.Text = editableCustomer.Address.Street;
			txtCity.Text = editableCustomer.Address.City;
			txtProvince.Text = editableCustomer.Address.Province;
			txtPostal.Text = editableCustomer.Address.PostalCode;
			txtPhone.Text = editableCustomer.Phone.ToString();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Customer customerEdit = new Customer();
			customerEdit.Name = txtName.Text;
			customerEdit.Phone = Convert.ToInt64(txtPhone.Text);
			Address addressEdit = new Address();
			addressEdit.Street = txtStreet.Text;
			addressEdit.City = txtCity.Text;
			addressEdit.Province = txtProvince.Text;
			addressEdit.PostalCode = txtPostal.Text;
			customerEdit.Address = addressEdit;
			Home.repository.Customers.Add(customerEdit);
			Home.PopulateListBox();
			this.Close();
		}
	}
}