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
	public partial class Add : Form
	{
		private Home Home;

		public Add(Home form)
		{
			InitializeComponent();
			Home = form;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Customer customerNew = new Customer();
			customerNew.Name = txtName.Text;
			customerNew.Phone = Convert.ToInt64(txtPhone.Text);
			Address addressNew = new Address();
			addressNew.Street = txtStreet.Text;
			addressNew.City = txtCity.Text;
			addressNew.Province = txtProvince.Text;
			addressNew.PostalCode = txtPostal.Text;

			customerNew.Address = addressNew;
			Home.repository.Customers.Add(customerNew);
			Home.PopulateListBox();
			this.Close();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtStreet_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtCity_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtProvince_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPhone_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPostal_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblOutput_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
