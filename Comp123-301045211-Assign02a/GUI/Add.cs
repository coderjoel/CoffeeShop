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
		public Add()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Program prog = new Program();
			CustomerRepository repo = new CustomerRepository();

			repo.Add(new Customer()
			{
				Name = txtName.Text,
				Phone = Convert.ToInt32(txtPhone.Text)
			});

			txtName.Text = txtCity.Text = txtPhone.Text = txtPostal.Text = txtProvince.Text = txtStreet.Text = string.Empty;
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
	}
}
