namespace CoffeShop.GUI
{
	partial class Home
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.listCustomers = new System.Windows.Forms.ListBox();
			this.listDisplay = new System.Windows.Forms.ListBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(328, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 109);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add Customer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(328, 167);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 109);
			this.button3.TabIndex = 2;
			this.button3.Text = "Add Order";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(351, 321);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 68);
			this.button5.TabIndex = 4;
			this.button5.Text = "Save";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// listCustomers
			// 
			this.listCustomers.FormattingEnabled = true;
			this.listCustomers.Location = new System.Drawing.Point(12, 21);
			this.listCustomers.Name = "listCustomers";
			this.listCustomers.Size = new System.Drawing.Size(227, 264);
			this.listCustomers.TabIndex = 5;
			this.listCustomers.SelectedIndexChanged += new System.EventHandler(this.listCustomers_SelectedIndexChanged);
			// 
			// listDisplay
			// 
			this.listDisplay.FormattingEnabled = true;
			this.listDisplay.Location = new System.Drawing.Point(541, 21);
			this.listDisplay.Name = "listDisplay";
			this.listDisplay.Size = new System.Drawing.Size(227, 264);
			this.listDisplay.TabIndex = 6;
			this.listDisplay.SelectedIndexChanged += new System.EventHandler(this.listDisplay_SelectedIndexChanged);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(87, 311);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.listDisplay);
			this.Controls.Add(this.listCustomers);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Name = "Home";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListBox listCustomers;
		private System.Windows.Forms.ListBox listDisplay;
		private System.Windows.Forms.Button btnEdit;
	}
}