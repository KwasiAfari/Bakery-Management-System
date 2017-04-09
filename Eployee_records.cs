﻿using System;
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
    public partial class Eployee_records : Form
    {
        string connect = "Data Source=AZIKA\\SQLEXPRESS;Initial Catalog=BakeryManagement;Integrated Security=True";
         SqlDataAdapter DDJEF = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Eployee_records()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "";
            if (malerb.Checked == true) { sex = "Male"; }
            else { sex = "Female"; }
            SqlConnection conn = new SqlConnection(connect);
            if (button1.Text != "Update")
            {
                DDJEF.InsertCommand = new SqlCommand();
                DDJEF.InsertCommand = new SqlCommand("Insert into Employee VALUES (@Name,@DOB,@Gender,@Address,@Contact)", conn);
                DDJEF.InsertCommand.Parameters.AddWithValue("@Name", txtEname.Text);
                DDJEF.InsertCommand.Parameters.AddWithValue("@DOB", Convert.ToDateTime(DOB.Text));
                DDJEF.InsertCommand.Parameters.AddWithValue("@Gender", sex);
                DDJEF.InsertCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                DDJEF.InsertCommand.Parameters.AddWithValue("@Contact", txtContact.Text);

                conn.Open();
                DDJEF.InsertCommand.ExecuteNonQuery();
                conn.Close();

                txtAddress.Text = "";
                txtContact.Text = "";
                txtEname.Text = "";
            }
        }

        private void Eployee_records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakery.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bakery.Employee);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
