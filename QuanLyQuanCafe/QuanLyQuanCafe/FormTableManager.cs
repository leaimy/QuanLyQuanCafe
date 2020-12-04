using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
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
			LoadTable();
		}

		#region Method

		void LoadTable()
		{
			List<Table> tableList = TableDAO.Instance.LoadTableList();
			foreach (Table item in tableList)
			{
				Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };

				btn.Text = item.Name + Environment.NewLine + item.Status;

				btn.ForeColor = Color.White;

				switch (item.Status)
				{
					case "Trống":
						btn.BackColor = Color.DeepPink;
						break;
						
					default:
						btn.BackColor = Color.BlueViolet;
						break;
				}

				flpTable.Controls.Add(btn);
			}
		}

		#endregion

		#region Events
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
		#endregion
	}
}
