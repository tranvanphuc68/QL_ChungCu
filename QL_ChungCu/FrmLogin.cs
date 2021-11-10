using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_ChungCu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string dtb = new KetNoi().dtb;
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "Select * from Admin where id = '" + username + "' AND pass = '" + password + "'";
            SqlConnection conn = new SqlConnection(dtb);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                MessageBox.Show("Successful");
                FrmQUANLY frmQUANLY = new FrmQUANLY();
                frmQUANLY.Show();
                this.Hide();
            }
            else MessageBox.Show("Failed");
        }
    }
}
