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
	public partial class Home : Form
	{
		public Customer selectCust;
		public List<Customer> Customers = new List<Customer>();
		public CustomerRepository repository = new CustomerRepository();

		public Home()
		{
			InitializeComponent();

			listCustomers.SelectionMode = SelectionMode.One;
			PopulateListBox();
		}

		public void PopulateListBox()
		{
			listCustomers.Items.Clear();
			foreach (var person in repository.Customers)
			{
				listCustomers.Items.Add(person);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Add form = new Add(this);
			form.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddOrder form = new AddOrder();
			form.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			selectCust = listCustomers.SelectedItem as Customer;
			Edit edit = new Edit(this, selectCust);
			edit.Show();
		}

		private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void listDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Home_Load(object sender, EventArgs e)
		{

		}
	}
}
