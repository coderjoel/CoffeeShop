namespace CoffeShop.GUI
{
	partial class DisplayOrder
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
			this.OrderItems = new System.Windows.Forms.ListBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OrderItems
			// 
			this.OrderItems.FormattingEnabled = true;
			this.OrderItems.Location = new System.Drawing.Point(205, 89);
			this.OrderItems.Name = "OrderItems";
			this.OrderItems.Size = new System.Drawing.Size(365, 225);
			this.OrderItems.TabIndex = 0;
			this.OrderItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(359, 346);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Go Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// DisplayOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.OrderItems);
			this.Name = "DisplayOrder";
			this.Text = "DisplayOrder";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox OrderItems;
		private System.Windows.Forms.Button btnBack;
	}
}