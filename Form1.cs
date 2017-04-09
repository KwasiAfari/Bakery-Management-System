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
    public partial class Form1 : Form
    {
        string connect = "Data Source=AZIKA\\SQLEXPRESS;Initial Catalog=BakeryManagement;Integrated Security=True";
        SqlDataAdapter DDJEF = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Please make sure the fields are not empty!");
                return;
            }
            SqlConnection conn = new SqlConnection(connect);
            SqlDataAdapter DDJEF = new SqlDataAdapter("Select * From Manager_Supervisor where Username=" + txtuser.Text + "Password=" + txtpass.Text , conn);
           

            if (txtuser.Text== "Username" || txtpass.Text=="Password")
            {
                this.Hide();
                Valley_View_Bakery parent = new Valley_View_Bakery();
                parent.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username And Password,Try again");
            }


            
            
        }
    }
}
