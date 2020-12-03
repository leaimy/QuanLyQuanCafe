
namespace QuanLyQuanCafe
{
	partial class frmTableManager
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
			this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.nmAmount = new System.Windows.Forms.NumericUpDown();
			this.cboFood = new System.Windows.Forms.ComboBox();
			this.cboCategory = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lvFood = new System.Windows.Forms.ListView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cboSwitchTable = new System.Windows.Forms.ComboBox();
			this.btnSwitchTable = new System.Windows.Forms.Button();
			this.nmDiscount = new System.Windows.Forms.NumericUpDown();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnCheckout = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.thôngTinTàiKhoảnToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(792, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuAdmin
			// 
			this.menuAdmin.Name = "menuAdmin";
			this.menuAdmin.Size = new System.Drawing.Size(55, 20);
			this.menuAdmin.Text = "Admin";
			this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
			// 
			// thôngTinTàiKhoảnToolStripMenuItem
			// 
			this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonalInfo,
            this.menuLogOut});
			this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
			this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
			// 
			// menuPersonalInfo
			// 
			this.menuPersonalInfo.Name = "menuPersonalInfo";
			this.menuPersonalInfo.Size = new System.Drawing.Size(171, 22);
			this.menuPersonalInfo.Text = "Thông tin cá nhân";
			this.menuPersonalInfo.Click += new System.EventHandler(this.menuPersonalInfo_Click);
			// 
			// menuLogOut
			// 
			this.menuLogOut.Name = "menuLogOut";
			this.menuLogOut.Size = new System.Drawing.Size(171, 22);
			this.menuLogOut.Text = "Đăng xuất";
			this.menuLogOut.Click += new System.EventHandler(this.menuLogOut_Click);
			// 
			// flpTable
			// 
			this.flpTable.Location = new System.Drawing.Point(10, 26);
			this.flpTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.flpTable.Name = "flpTable";
			this.flpTable.Size = new System.Drawing.Size(418, 519);
			this.flpTable.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnAddFood);
			this.panel1.Controls.Add(this.nmAmount);
			this.panel1.Controls.Add(this.cboFood);
			this.panel1.Controls.Add(this.cboCategory);
			this.panel1.Location = new System.Drawing.Point(432, 25);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(350, 60);
			this.panel1.TabIndex = 3;
			// 
			// btnAddFood
			// 
			this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddFood.Location = new System.Drawing.Point(183, 2);
			this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(86, 55);
			this.btnAddFood.TabIndex = 4;
			this.btnAddFood.Text = "Thêm món";
			this.btnAddFood.UseVisualStyleBackColor = true;
			// 
			// nmAmount
			// 
			this.nmAmount.Location = new System.Drawing.Point(289, 22);
			this.nmAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nmAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.nmAmount.Name = "nmAmount";
			this.nmAmount.Size = new System.Drawing.Size(61, 20);
			this.nmAmount.TabIndex = 3;
			this.nmAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nmAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cboFood
			// 
			this.cboFood.FormattingEnabled = true;
			this.cboFood.Location = new System.Drawing.Point(2, 38);
			this.cboFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cboFood.Name = "cboFood";
			this.cboFood.Size = new System.Drawing.Size(161, 21);
			this.cboFood.TabIndex = 2;
			// 
			// cboCategory
			// 
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new System.Drawing.Point(0, 1);
			this.cboCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new System.Drawing.Size(161, 21);
			this.cboCategory.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lvFood);
			this.panel2.Location = new System.Drawing.Point(433, 101);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(349, 370);
			this.panel2.TabIndex = 4;
			// 
			// lvFood
			// 
			this.lvFood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvFood.Location = new System.Drawing.Point(0, 0);
			this.lvFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lvFood.Name = "lvFood";
			this.lvFood.Size = new System.Drawing.Size(349, 370);
			this.lvFood.TabIndex = 0;
			this.lvFood.UseCompatibleStateImageBehavior = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cboSwitchTable);
			this.panel3.Controls.Add(this.btnSwitchTable);
			this.panel3.Controls.Add(this.nmDiscount);
			this.panel3.Controls.Add(this.btnDiscount);
			this.panel3.Controls.Add(this.btnCheckout);
			this.panel3.Location = new System.Drawing.Point(432, 487);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(350, 58);
			this.panel3.TabIndex = 5;
			// 
			// cboSwitchTable
			// 
			this.cboSwitchTable.FormattingEnabled = true;
			this.cboSwitchTable.Location = new System.Drawing.Point(0, 36);
			this.cboSwitchTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cboSwitchTable.Name = "cboSwitchTable";
			this.cboSwitchTable.Size = new System.Drawing.Size(87, 21);
			this.cboSwitchTable.TabIndex = 5;
			// 
			// btnSwitchTable
			// 
			this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSwitchTable.Location = new System.Drawing.Point(0, 2);
			this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSwitchTable.Name = "btnSwitchTable";
			this.btnSwitchTable.Size = new System.Drawing.Size(86, 28);
			this.btnSwitchTable.TabIndex = 4;
			this.btnSwitchTable.Text = "Chuyển bàn";
			this.btnSwitchTable.UseVisualStyleBackColor = true;
			// 
			// nmDiscount
			// 
			this.nmDiscount.Location = new System.Drawing.Point(125, 36);
			this.nmDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nmDiscount.Name = "nmDiscount";
			this.nmDiscount.Size = new System.Drawing.Size(86, 20);
			this.nmDiscount.TabIndex = 3;
			this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnDiscount
			// 
			this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDiscount.Location = new System.Drawing.Point(125, 2);
			this.btnDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(86, 28);
			this.btnDiscount.TabIndex = 2;
			this.btnDiscount.Text = "Giảm giá";
			this.btnDiscount.UseVisualStyleBackColor = true;
			// 
			// btnCheckout
			// 
			this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckout.Location = new System.Drawing.Point(261, 2);
			this.btnCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCheckout.Name = "btnCheckout";
			this.btnCheckout.Size = new System.Drawing.Size(86, 56);
			this.btnCheckout.TabIndex = 1;
			this.btnCheckout.Text = "Thanh toán";
			this.btnCheckout.UseVisualStyleBackColor = true;
			// 
			// frmTableManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 555);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flpTable);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmTableManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phần mềm quản lý quán cafe";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuAdmin;
		private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuPersonalInfo;
		private System.Windows.Forms.ToolStripMenuItem menuLogOut;
		private System.Windows.Forms.FlowLayoutPanel flpTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListView lvFood;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.NumericUpDown nmAmount;
		private System.Windows.Forms.ComboBox cboFood;
		private System.Windows.Forms.ComboBox cboCategory;
		private System.Windows.Forms.ComboBox cboSwitchTable;
		private System.Windows.Forms.Button btnSwitchTable;
		private System.Windows.Forms.NumericUpDown nmDiscount;
		private System.Windows.Forms.Button btnDiscount;
		private System.Windows.Forms.Button btnCheckout;
	}
}