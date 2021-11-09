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

        KetNoi connect = new KetNoi();
        string dtb = new KetNoi().dtb;

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table_In = new DataTable();
        DataTable table_Out = new DataTable();
        DataTable table_Example = new DataTable();


        void load_In()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select id as 'Biển số', uid, type as 'Loại', fee as 'Phí', timeIn as 'Thời gian vào' from Xe_vao order by timeIn desc";
            adapter.SelectCommand = cmd;
            table_In.Clear();
            adapter.Fill(table_In);
            viewIn.DataSource = table_In;
        }

        void load_Out()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select id as 'Biển số', type as 'Loại', timeOut as 'Thời gian ra' from Xe_ra order by timeOut desc";
            adapter.SelectCommand = cmd;
            table_Out.Clear();
            adapter.Fill(table_Out);
            viewOut.DataSource = table_Out;
        }

        void blank()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from Xe_vao where type = " + "'Xe Máy'";
            Int32 motor_count = (Int32)cmd.ExecuteScalar();
            int motor = 200 - motor_count;
            cmd.CommandText = "select count(*) from Xe_vao where type = " + "'Ô tô'";
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
            else
            {
                SqlCommand cmd = new SqlCommand("select uid from Xe_vao where uid = '" + uid.Text + "' group by uid", conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                
                if (reader.Read() == true)
                {   
                    MessageBox.Show("Nhập UID khác");
                    reader.Close();
                    goto end;
                }
                reader.Close();
            }
            connect.Thuc_thi("insert into Xe_vao(uid,id,type,fee,timeIn) values('" + uid.Text + "','" + id.Text + "','" + type.Text + "'," + fee + ",'" + timeIn.ToString() + "')");
            blank();
            uid.ResetText();
            id.ResetText();
            type.ResetText();
        end: load_In();
        }

        private void xeRa_Click(object sender, EventArgs e)
        {   
            SqlCommand cmd = new SqlCommand("select * from Xe_vao where uid = '" + checkUID.Text + "'", conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read() == true) 
            {
                checkID.Text = (string)reader["id"].ToString();
                checkType.Text = (string)reader["type"].ToString();
                checkFee.Text = (string)reader["fee"].ToString();
            }
            reader.Close();
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
            connect.Thuc_thi("insert into Xe_ra(id,type,timeOut) values('" + checkID.Text + "','" + checkType.Text + "','" + timeOut.ToString() + "')");
            connect.Thuc_thi("delete from Xe_vao where id = '" + checkID.Text + "'");
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
