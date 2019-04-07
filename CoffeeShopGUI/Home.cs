using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopGUI
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Add obj1 = new Add();
			obj1.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Display obj1 = new Display();
			obj1.Show();
			this.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddOrder obj1 = new AddOrder();
			obj1.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DisplayOrder obj1 = new DisplayOrder();
			obj1.Show();
			this.Hide();
		}
	}
}
