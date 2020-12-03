
namespace QuanLyQuanCafe
{
	partial class frmLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNameLogin = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(547, 244);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtNameLogin);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(540, 81);
			this.panel2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập";
			// 
			// txtNameLogin
			// 
			this.txtNameLogin.Location = new System.Drawing.Point(192, 23);
			this.txtNameLogin.Name = "txtNameLogin";
			this.txtNameLogin.Size = new System.Drawing.Size(333, 30);
			this.txtNameLogin.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtPassword);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(4, 91);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(540, 82);
			this.panel3.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(192, 24);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(333, 30);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu";
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(196, 194);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(112, 36);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(428, 194);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(101, 36);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(572, 269);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtNameLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
	}
}

