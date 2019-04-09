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
	public partial class AddOrder : Form
	{
		public CoffeeShopClassLibrary.MenuItem repository = new CoffeeShopClassLibrary.MenuItem();

		public AddOrder()
		{
			InitializeComponent();
		}

		private void btnAddOrder_Click(object sender, EventArgs e)
		{

		}

		private void AddOrder_Load(object sender, EventArgs e)
		{

		}

		private void btnAddOrder_Click_1(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

		}

		public void PopulateListBox()
		{
			MenuItems.Items.Clear();
			foreach (var person in repository.Description)
			{
				MenuItems.Items.Add(person);
			}
		}

		private void MenuItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void lblCost_Click(object sender, EventArgs e)
		{

		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Home form = new Home();
			form.Show();
			this.Hide();
		}
	}
}
