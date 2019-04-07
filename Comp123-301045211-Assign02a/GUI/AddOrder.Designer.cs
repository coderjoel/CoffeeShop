namespace CoffeShop.GUI
{
	partial class AddOrder
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
			this.btnAddOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.MenuItems = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCost = new System.Windows.Forms.Label();
			this.btnAddOrder = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAddOk
			// 
			this.btnAddOk.Location = new System.Drawing.Point(201, 358);
			this.btnAddOk.Name = "btnAddOk";
			this.btnAddOk.Size = new System.Drawing.Size(75, 23);
			this.btnAddOk.TabIndex = 0;
			this.btnAddOk.Text = "Ok";
			this.btnAddOk.UseVisualStyleBackColor = true;
			this.btnAddOk.Click += new System.EventHandler(this.btnAddOrder_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(337, 358);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// MenuItems
			// 
			this.MenuItems.FormattingEnabled = true;
			this.MenuItems.Location = new System.Drawing.Point(182, 51);
			this.MenuItems.Name = "MenuItems";
			this.MenuItems.Size = new System.Drawing.Size(257, 225);
			this.MenuItems.TabIndex = 2;
			this.MenuItems.SelectedIndexChanged += new System.EventHandler(this.MenuItems_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(243, 317);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Cost : ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblCost
			// 
			this.lblCost.AutoSize = true;
			this.lblCost.Location = new System.Drawing.Point(297, 317);
			this.lblCost.Name = "lblCost";
			this.lblCost.Size = new System.Drawing.Size(37, 13);
			this.lblCost.TabIndex = 4;
			this.lblCost.Text = "_____";
			this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
			// 
			// btnAddOrder
			// 
			this.btnAddOrder.Location = new System.Drawing.Point(467, 164);
			this.btnAddOrder.Name = "btnAddOrder";
			this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
			this.btnAddOrder.TabIndex = 5;
			this.btnAddOrder.Text = "Add";
			this.btnAddOrder.UseVisualStyleBackColor = true;
			this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click_1);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(653, 388);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 6;
			this.btnBack.Text = "Go Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// AddOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnAddOrder);
			this.Controls.Add(this.lblCost);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MenuItems);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAddOk);
			this.Name = "AddOrder";
			this.Text = "AddOrder";
			this.Load += new System.EventHandler(this.AddOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListBox MenuItems;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCost;
		private System.Windows.Forms.Button btnAddOrder;
		private System.Windows.Forms.Button btnBack;
	}
}