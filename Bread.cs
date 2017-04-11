using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bakery_Management_System
{
    public partial class Bread : Form
    {
        string connect = "Data Source=(localdb)\\v11.0;Initial Catalog=BakerySystem;Integrated Security=True";
        SqlDataAdapter DDJEF = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Bread()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            if (btninsert.Text != "Update")
            {
                DDJEF.InsertCommand = new SqlCommand();
                DDJEF.InsertCommand = new SqlCommand("Insert into Bread VALUES (@BreadType,@BreadSize,@Quantity,@Price)", conn);
                DDJEF.InsertCommand.Parameters.AddWithValue("@BreadType", bttxt.Text);
                DDJEF.InsertCommand.Parameters.AddWithValue("@BreadSize", cbbs.SelectedValue);
                DDJEF.InsertCommand.Parameters.AddWithValue("@Quantity", Quantitytxt.Text);
                DDJEF.InsertCommand.Parameters.AddWithValue("@Price", cbp.SelectedValue);

                conn.Open();
                DDJEF.InsertCommand.ExecuteNonQuery();
                conn.Close();

                cbbs.SelectedValue = "";
                bttxt.Text = "";
                cbp.SelectedValue = "";
            }
        }

        private void Bread_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakery.Bread' table. You can move, or remove it, as needed.
            this.breadTableAdapter.Fill(this.bakery.Bread);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect);
            {
                DDJEF.UpdateCommand = new SqlCommand();
                DDJEF.UpdateCommand = new SqlCommand("UPDATE [BakerySystem].[dbo].[Bread] SET BreadType=@BreadType,BreadSize=@BreadSize,Quantity=@Quantity, Prices=@Prices, where BreadType=@BreadType", conn);
                DDJEF.UpdateCommand.Parameters.AddWithValue("@BreadType", bttxt.Text);
                DDJEF.UpdateCommand.Parameters.AddWithValue("@BreadSize", cbbs.SelectedValue);
                DDJEF.UpdateCommand.Parameters.AddWithValue("@Quantity", Quantitytxt.Text);
                DDJEF.UpdateCommand.Parameters.AddWithValue("@Price", cbp.SelectedValue);

                conn.Open();
                DDJEF.UpdateCommand.ExecuteNonQuery();
                conn.Close();

                cbbs.SelectedValue = "";
                bttxt.Text = "";
                cbp.SelectedValue = "";

            }

        }
    }
}
