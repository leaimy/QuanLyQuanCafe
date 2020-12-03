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
	public partial class frmTableManager : Form
	{
		public frmTableManager()
		{
			InitializeComponent();
		}

		private void menuLogOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void menuPersonalInfo_Click(object sender, EventArgs e)
		{
			frmAccountProfile frmAccountProfile = new frmAccountProfile();
			frmAccountProfile.ShowDialog();
		}

		private void menuAdmin_Click(object sender, EventArgs e)
		{
			frmAdmin frmAdmin = new frmAdmin();
			frmAdmin.ShowDialog();
		}
	}
}
