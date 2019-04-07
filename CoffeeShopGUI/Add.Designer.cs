namespace CoffeeShopGUI
{
	partial class Add
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
			this.AddBtnClick = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textCity = new System.Windows.Forms.TextBox();
			this.textPhone = new System.Windows.Forms.TextBox();
			this.textPostalCode = new System.Windows.Forms.TextBox();
			this.textProvince = new System.Windows.Forms.TextBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.textStreet = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddBtnClick
			// 
			this.AddBtnClick.Location = new System.Drawing.Point(400, 304);
			this.AddBtnClick.Name = "AddBtnClick";
			this.AddBtnClick.Size = new System.Drawing.Size(75, 23);
			this.AddBtnClick.TabIndex = 25;
			this.AddBtnClick.Text = "Add";
			this.AddBtnClick.UseVisualStyleBackColor = true;
			this.AddBtnClick.Click += new System.EventHandler(this.button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(315, 257);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "Phone No.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(314, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Postal Code";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(315, 204);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Province";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(316, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "City";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(315, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Street No.";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(315, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Name";
			// 
			// textCity
			// 
			this.textCity.Location = new System.Drawing.Point(386, 175);
			this.textCity.Name = "textCity";
			this.textCity.Size = new System.Drawing.Size(100, 20);
			this.textCity.TabIndex = 18;
			// 
			// textPhone
			// 
			this.textPhone.Location = new System.Drawing.Point(386, 253);
			this.textPhone.Name = "textPhone";
			this.textPhone.Size = new System.Drawing.Size(100, 20);
			this.textPhone.TabIndex = 17;
			// 
			// textPostalCode
			// 
			this.textPostalCode.Location = new System.Drawing.Point(386, 227);
			this.textPostalCode.Name = "textPostalCode";
			this.textPostalCode.Size = new System.Drawing.Size(100, 20);
			this.textPostalCode.TabIndex = 16;
			// 
			// textProvince
			// 
			this.textProvince.Location = new System.Drawing.Point(386, 201);
			this.textProvince.Name = "textProvince";
			this.textProvince.Size = new System.Drawing.Size(100, 20);
			this.textProvince.TabIndex = 15;
			// 
			// textName
			// 
			this.textName.Location = new System.Drawing.Point(386, 123);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(100, 20);
			this.textName.TabIndex = 14;
			// 
			// textStreet
			// 
			this.textStreet.Location = new System.Drawing.Point(386, 149);
			this.textStreet.Name = "textStreet";
			this.textStreet.Size = new System.Drawing.Size(100, 20);
			this.textStreet.TabIndex = 13;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(422, 364);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(39, 13);
			this.lblOutput.TabIndex = 26;
			this.lblOutput.Text = "Output";
			// 
			// Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.AddBtnClick);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textCity);
			this.Controls.Add(this.textPhone);
			this.Controls.Add(this.textPostalCode);
			this.Controls.Add(this.textProvince);
			this.Controls.Add(this.textName);
			this.Controls.Add(this.textStreet);
			this.Name = "Add";
			this.Text = "Add";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddBtnClick;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textCity;
		private System.Windows.Forms.TextBox textPhone;
		private System.Windows.Forms.TextBox textPostalCode;
		private System.Windows.Forms.TextBox textProvince;
		private System.Windows.Forms.TextBox textName;
		private System.Windows.Forms.TextBox textStreet;
		private System.Windows.Forms.Label lblOutput;
	}
}