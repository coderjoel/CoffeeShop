using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop.GUI
{
	public partial class Edit : Form
	{
		public Edit()
		{
			InitializeComponent();
		}

		private void btnEdit_Click(object sender, EventArgs e)
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
