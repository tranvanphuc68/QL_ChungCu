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

namespace QL_ChungCu
{
    public partial class FrmThanhToanDichVu : Form
    {
        public FrmThanhToanDichVu()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        string dtb = new KetNoi().dtb;
        SqlConnection connect;

        public void Load_DanCu()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("SELECT ma_HD_DV as 'Mã hợp đồng', thanh_toan, Ho_dan.ma_ho as 'Mã hộ dân', ten_chu_ho as 'Chủ hộ', ten_DV as 'Dịch vụ', he_so as 'Hệ số', FORMAT(he_so *don_gia, '### ### ###') as 'Tổng', thang as 'Tháng', nam as 'Năm', CASE thanh_toan WHEN '0' THEN 'Chưa thanh toán'WHEN '1' THEN 'Đã thanh toán' END as 'Trạng thái' " +
                "FROM Dich_vu, Ho_dan, Thong_tin_dich_vu " +
                "WHERE Dich_vu.ma_DV = Thong_tin_dich_vu.ma_DV AND Ho_dan.ma_ho = Dich_vu.ma_ho;");
            dtGridViewDV.DataSource = table;

        }

        public void Load_MaHo()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select* from Ho_dan");
            cbbMaHo.DataSource = table;
            cbbMaHo.DisplayMember = "ma_ho";
            cbbMaHo.ValueMember = "ma_ho";
        }

        public void Load_MaDV()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select * from Thong_tin_dich_vu");
            cbbDV.DataSource = table;
            cbbDV.DisplayMember = "ten_DV";
            cbbDV.ValueMember = "ma_DV";
        }

        public void Load_Thang()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select DISTINCT thang from Dich_vu");
            cbbMonth.DataSource = table;
            cbbMonth.DisplayMember = "thang";
            cbbMonth.ValueMember = "thang";
        }
        public void Load_Nam()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select DISTINCT nam from Dich_vu");
            cbbYear.DataSource = table;
            cbbYear.DisplayMember = "nam";
            cbbYear.ValueMember = "nam";
        }


        public void Load_HienThi()
        {
            txtMaHDDV.DataBindings.Clear();
            txtMaHDDV.DataBindings.Add("text", dtGridViewDV.DataSource, "Mã hợp đồng");
            txtChuHo.DataBindings.Clear();
            txtChuHo.DataBindings.Add("text", dtGridViewDV.DataSource, "Chủ hộ");
            cbbMaHo.DataBindings.Clear();
            cbbMaHo.DataBindings.Add("text", dtGridViewDV.DataSource, "Mã hộ dân");
            cbbMonth.DataBindings.Clear();
            cbbMonth.DataBindings.Add("text", dtGridViewDV.DataSource, "Tháng");
            cbbYear.DataBindings.Clear();
            cbbYear.DataBindings.Add("text", dtGridViewDV.DataSource, "Năm");
            cbbDV.DataBindings.Clear();
            cbbDV.DataBindings.Add("text", dtGridViewDV.DataSource, "Dịch vụ");
            txtHeso.DataBindings.Clear();
            txtHeso.DataBindings.Add("text", dtGridViewDV.DataSource, "Hệ số");
            //txtThanhToan.DataBindings.Clear();
            //txtThanhToan.DataBindings.Add("text", dtGridViewDV.DataSource, "Tổng");
            chbStatus.DataBindings.Clear();
            chbStatus.DataBindings.Add("checked", dtGridViewDV.DataSource, "thanh_toan");
        }

        public void Load_ChuHo()
        {

        }
        public void Load_all()
        {
            Load_DanCu();
            Load_MaHo();
            Load_MaDV();
            Load_Thang();
            Load_Nam();
            Load_ChuHo();
            txtMaHDDV.Hide();
            dtGridViewDV.Columns[0].Visible = false;
            dtGridViewDV.Columns[1].Visible = false;
        }
        private void FrmThanhToanDichVu_Load(object sender, EventArgs e)
        {
            Load_all();
            Load_HienThi();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Thuc_thi("UPDATE Dich_vu SET he_so = '" + txtHeso.Text + "' WHERE ma_HD_DV = '" + txtMaHDDV.Text + "'");
            if (chbStatus.Checked == true)
            {
                conn.Thuc_thi("UPDATE Dich_vu SET thanh_toan = '1' WHERE ma_HD_DV = '" + txtMaHDDV.Text + "'");

            }
            else
            {
                conn.Thuc_thi("UPDATE Dich_vu SET thanh_toan = '0' WHERE ma_HD_DV = '" + txtMaHDDV.Text + "'");
            }
            MessageBox.Show("Cập nhật thành công hộ dân" + cbbMaHo.Text + "(" + txtChuHo.Text + ") dịch vụ " + cbbDV.Text + " tháng " + cbbMonth.SelectedValue + "/" + cbbYear.SelectedValue );
            Load_all();
            
            
        }

        private void cbbMaHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect = new SqlConnection(dtb);
            connect.Open();

            string query = "SELECT ten_chu_ho FROM Ho_dan WHERE ma_ho = '" + cbbMaHo.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = (string)reader["ten_chu_ho"].ToString();
                txtChuHo.Text = name;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            
                table = conn.Lay_du_lieu("Select ma_HD_DV as 'Mã hợp đồng', thanh_toan, Ho_dan.ma_ho as 'Mã hộ dân', ten_chu_ho as 'Chủ hộ', ten_DV as 'Dịch vụ', he_so as 'Hệ số', FORMAT(he_so *don_gia, '### ### ###') as 'Tổng', thang as 'Tháng', nam as 'Năm',  CASE thanh_toan WHEN '0' THEN 'Chưa thanh toán'WHEN '1' THEN 'Đã thanh toán' END as 'Trạng thái' " +
                    "FROM Thong_tin_dich_vu, Dich_vu, Ho_dan " +
                    "WHERE Dich_vu.ma_DV = Thong_tin_dich_vu.ma_DV AND Ho_dan.ma_ho = Dich_vu.ma_ho " +
                        "AND ten_DV LIKE '%" + cbbDV.Text + "%' " +
                        "AND Ho_dan.ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%' " +
                        "AND thang LIKE '%" + cbbMonth.SelectedValue + "%' " +
                        "AND nam LIKE '%" + cbbYear.SelectedValue + "%'");


            /*else
            {
                table = conn.Lay_du_lieu("Select ma_HD_DV as 'Mã hợp đồng', Ho_dan.ma_ho as 'Mã hộ dân', ten_chu_ho as 'Chủ hộ', ten_DV as 'Dịch vụ', he_so as 'Hệ số', he_so * don_gia as 'Tổng', thang as 'Tháng', nam as 'Năm', thanh_toan " +
                    "FROM Thong_tin_dich_vu, Dich_vu, Ho_dan " +
                    "WHERE Dich_vu.ma_DV = Thong_tin_dich_vu.ma_DV AND Ho_dan.ma_ho = Dich_vu.ma_ho" +
                        "AND ten_DV LIKE '%" + cbbDV.Text  + "%' " +
                        "AND Ho_dan.ma_ho LIKE '%" + cbbMaHo.SelectedText + "%' " +
                        "AND ten_chu_ho LIKE '%" + txtChuHo.Text + "%' " +
                        "AND thang LIKE '%" + cbbMonth.SelectedValue + "%' " +
                        "AND nam LIKE '%" + cbbYear.SelectedValue + "%'");
            }*/
            
            dtGridViewDV.DataSource = table;
            Load_HienThi();

        }

        private void dtGridViewDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_HienThi();
        }

        private void txtHeso_TextChanged(object sender, EventArgs e)
        {
            connect = new SqlConnection(dtb);
            connect.Open();

            string query = "SELECT don_gia FROM Thong_tin_dich_vu WHERE ma_DV = '" + cbbDV.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string don_gia = (string)reader["don_gia"].ToString();
                float price = float.Parse(don_gia);
                if (txtHeso.Text != "")
                {
                    float he_so = float.Parse(txtHeso.Text);

                    txtThanhToan.Text = (he_so * price).ToString("### ### ###");
                }    
             
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_all();
        }
    }
}
