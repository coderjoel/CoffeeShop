﻿namespace CoffeShop.GUI
{
	partial class Display
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
			this.CustomerListBox = new System.Windows.Forms.ListBox();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CustomerListBox
			// 
			this.CustomerListBox.FormattingEnabled = true;
			this.CustomerListBox.Location = new System.Drawing.Point(277, 82);
			this.CustomerListBox.Name = "CustomerListBox";
			this.CustomerListBox.Size = new System.Drawing.Size(223, 173);
			this.CustomerListBox.TabIndex = 0;
			this.CustomerListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerListBox_SelectedIndexChanged);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(355, 290);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(640, 388);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 2;
			this.btnBack.Text = "Go Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// Display
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.CustomerListBox);
			this.Name = "Display";
			this.Text = "Display";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox CustomerListBox;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnBack;
	}
}