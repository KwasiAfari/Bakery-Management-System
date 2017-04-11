using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Bakery_Management_System
{
    public partial class Comments : System.Web.UI.Page
    {
        string connect = "Data Source=(localdb)\\v11.0;Initial Catalog=BakerySystem;Integrated Security=True";
        SqlDataAdapter DDJEF = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_onclick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            DDJEF.InsertCommand = new SqlCommand("Insert into [BakerySystem].[dbo].[CNS]  VALUES (@Comment,@Suggestions)", conn);
            DDJEF.InsertCommand.Parameters.AddWithValue("@Comment", comment.Text);
            DDJEF.InsertCommand.Parameters.AddWithValue("@Suggestions", Suggestions.Text);

            conn.Open();
            DDJEF.InsertCommand.ExecuteNonQuery();
            conn.Close();

            comment.Text = "";
            Suggestions.Text = "";

        }
    }
}