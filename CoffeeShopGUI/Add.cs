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

namespace CoffeeShopGUI
{
	public partial class Add : Form
	{
		public List<CustomerRepository> Persons = new List<Person>();

		public Add()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Persons.Add(new Person()
			{
				Name = textName.Text,
				Age = Convert.ToInt32(AgeTextBox.Text)
			});

			textName.Text = AgeTextBox.Text = string.Empty;
			PopulateListBox();
		}
	}
}
