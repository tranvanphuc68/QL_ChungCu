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
    public partial class FrmBaiDoXe : Form
    {
        public FrmBaiDoXe()
        {
            InitializeComponent();
        }

        string dtb = @"Data Source=LAPTOP-GL3J5C27\SQLEXPRESS;Initial Catalog=PARKING;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table_In = new DataTable();
        DataTable table_Out = new DataTable();
        DataTable table_Example = new DataTable();


        void load_In()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from XeVao";
            adapter.SelectCommand = cmd;
            table_In.Clear();
            adapter.Fill(table_In);
            viewIn.DataSource = table_In;
        }

        void load_Out()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from XeRa";
            adapter.SelectCommand = cmd;
            table_Out.Clear();
            adapter.Fill(table_Out);
            viewOut.DataSource = table_Out;
        }

        void blank()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from XeVao where type = " + "'Xe Máy'";
            Int32 motor_count = (Int32)cmd.ExecuteScalar();
            int motor = 200 - motor_count;
            cmd.CommandText = "select count(*) from XeVao where type = " + "'Ô tô'";
            Int32 car_count = (Int32)cmd.ExecuteScalar();
            int car = 100 - car_count;
            Car.Text = car.ToString();
            Motor.Text = motor.ToString();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dtb);
            conn.Open();
            blank();
            load_In();
            load_Out();
        }

        private void xeVao_Click(object sender, EventArgs e)
        {
            int fee;
            if (type.Text == "Xe máy")
                fee = 5000;
            else fee = 10000;
            DateTime timeIn = DateTime.Now;
            if (type.Text == "" || uid.Text == "" || id.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ");
                goto end;
            }
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into XeVao(uid,id,type,fee,timeIn) values('" + uid.Text + "','" + id.Text + "','" + type.Text + "'," + fee + ",'" + timeIn.ToString() + "')";
            cmd.ExecuteNonQuery();
            blank();
            uid.ResetText();
            id.ResetText();
            type.ResetText();
        end: load_In();
        }

        private void xeRa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from XeVao where uid = '" + checkUID.Text + "'";
            adapter.SelectCommand = cmd;
            table_In.Clear();
            adapter.Fill(table_In);
            if (table_In.Rows.Count == 1)  //kiểm tra tồn tại xe
            {
                checkID.Text = viewIn.Rows[0].Cells[1].Value.ToString();
                checkType.Text = viewIn.Rows[0].Cells[2].Value.ToString();
                checkFee.Text = viewIn.Rows[0].Cells[3].Value.ToString();
            }
            load_In();
        }

        private void checkXeRa_Click(object sender, EventArgs e)
        {
            if (checkID.Text == "")
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ");
                goto end;
            }
            DateTime timeOut = DateTime.Now;
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into XeRa(id,type,timeOut) values('" + checkID.Text + "','" + checkType.Text + "','" + timeOut.ToString() + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from XeVao where id = '" + checkID.Text + "'";
            cmd.ExecuteNonQuery();
            blank();
            load_In();
            load_Out();
            checkID.ResetText();
            checkFee.ResetText();
            checkType.ResetText();
            checkUID.ResetText();
        end: load_In();
        }

    }
}
