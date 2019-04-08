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
			this.Hide();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Edit form = new Edit(this);
			form.Show();
		}

		private void listCustomers_SelectedIndexChanged(object sender, EventArgs e)
		{
			//(listCustomers.SelectedItem as Customer).Age++;

			var person = Customers.FirstOrDefault(
				tPerson =>
					tPerson.Name == (listCustomers.SelectedItem as Customer).Name
				);


			Edit form = new Edit(this);
			form.Show();
		}

		private void listDisplay_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Home_Load(object sender, EventArgs e)
		{

		}
	}
}
