using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
	public class DataProvider
	{
			private string connectionSTR = "Data Source=.;Initial Catalog=QLQuanCafe;Integrated Security=True";
		
		public DataTable ExecuteQuery(string query)
		{
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);

				adapter.Fill(data);

				connection.Close();
			}
			return data;
		}
	}
}
