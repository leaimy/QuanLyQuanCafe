﻿using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userName = txtNameLogin.Text;
			string passWord = txtPassword.Text;
			if (Login(userName, passWord))
			{
				frmTableManager frmTableManager = new frmTableManager();
				this.Hide();
				frmTableManager.ShowDialog();
				this.Show();
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
			}
		}

		bool Login(string userName,string passWord)
		{
			return AccountDAO.Instance.Login(userName, passWord);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát? ", "Thông báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult!=DialogResult.Yes)
			{
				e.Cancel = true;
			}
		}
	}
}
