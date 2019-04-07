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
	public partial class Display : Form
	{
		public List<Customer> Persons = new List<Customer>();

		public Display()
		{
			InitializeComponent();

			CustomerListBox.SelectionMode = SelectionMode.One;
			PopulateListBox();
		}

		private void PopulateListBox()
		{
			CustomerListBox.Items.Clear();
			foreach (var person in Persons)
			{
				CustomerListBox.Items.Add(person);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{

		}

		private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
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
