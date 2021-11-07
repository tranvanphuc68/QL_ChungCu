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
    public partial class FrmHopDongThue : Form
    {
        public FrmHopDongThue()
        {
            InitializeComponent();
        }

        KetNoi ketNoi = new KetNoi();

        private void cbxMaHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Ho_dan WHERE ma_ho = '" + cbxMaHo.Text+ "'", ketNoi.conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtTenChuHo.Text = (string)reader["ten_chu_ho"].ToString();
            }
            reader.Close();
        }

        public void get_ho_dan()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT ma_ho,ten_chu_ho FROM Ho_dan");
            cbxMaHo.DataSource = table;
            cbxMaHo.DisplayMember = "ma_ho";
            cbxMaHo.ValueMember = "ma_ho";
        }

        private void cbxMaTaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ma_TS,ten_TS,don_gia,nhap_kho - dang_cho_thue as co_the_thue FROM Kho_tai_san WHERE ma_TS = '" + cbxMaTaiSan.Text + "'", ketNoi.conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtTenTaiSan.Text = (string)reader["ten_TS"].ToString();
                txtCoTheThue.Text = (string)reader["co_the_thue"].ToString();
                txtDonGia.Text = (string)reader["don_gia"].ToString();
                string dongia = (string)reader["don_gia"].ToString();
                float don_gia = float.Parse(dongia);
                String soLuong = (txtSoLuong.Text);
                
                bool sl = Int32.TryParse(soLuong, out int so_luong);
                txtThanhTien.Text = (so_luong * don_gia).ToString();
            }
            reader.Close();
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ma_TS,don_gia FROM Kho_tai_san WHERE ma_TS = '" + cbxMaTaiSan.Text + "'", ketNoi.conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dongia = (string)reader["don_gia"].ToString();
                float don_gia = float.Parse(dongia);
                String soLuong = (txtSoLuong.Text);

                bool sl = Int32.TryParse(soLuong, out int so_luong);
                txtThanhTien.Text = (so_luong * don_gia).ToString();
            }
            reader.Close();
        }
        public void get_kho_tai_san()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT ma_TS FROM Kho_tai_san");
            cbxMaTaiSan.DataSource = table;
            cbxMaTaiSan.DisplayMember = "ma_TS";
            cbxMaTaiSan.ValueMember = "ma_TS";
        }

        public void get_hop_dong_thue()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu(
                "SELECT ma_hop_dong,Hop_dong_thue.ma_ho,Hop_dong_thue.ma_TS,so_luong, so_luong * don_gia as thanh_tien,thoi_gian_vao as bat_dau,thoi_gian_ra as ket_thuc " +
                "FROM Ho_dan,Kho_tai_san,Hop_dong_thue " +
                "WHERE Ho_dan.ma_ho = Hop_dong_thue.ma_ho AND Kho_tai_san.ma_TS = Hop_dong_thue.ma_TS");
            dataGridView_HDT.DataSource = table;
        }
        
        public void load()
        {
            get_ho_dan();
            get_kho_tai_san();
            get_hop_dong_thue();
            txtSoLuong.Text = "";
            txtMaHopDong.Text = "";
            btnDelete.Enabled = false;
        }

        private void FrmHopDongThue_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime endDate = now.AddDays(60);
            int coTheThue = int.Parse(txtCoTheThue.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            string ma_hop_dong = "SELECT ma_hop_dong FROM Hop_dong_thue WHERE ma_hop_dong = '" + txtMaHopDong.Text + "'";
            SqlCommand cmd = new SqlCommand(ma_hop_dong, ketNoi.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                MessageBox.Show("Mã Hợp Đồng Đã Tồn Tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (soLuong > coTheThue)
            {
                MessageBox.Show("Số Lượng Hàng Trong Kho Không Đủ, Vui Lòng Nhập Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string insert = "INSERT INTO Hop_dong_thue(ma_ho,ma_TS,thoi_gian_vao,thoi_gian_ra,so_luong) VALUES ('" + cbxMaHo.Text + "', '" + cbxMaTaiSan.Text + "', '" + now.ToString("yyyy-MM-dd") + "', '" +endDate.ToString("yyyy-MM-dd") +"', '" + txtSoLuong.Text + "')";
                ketNoi.Thuc_thi(insert);

                string update = "UPDATE Kho_tai_san SET dang_cho_thue = dang_cho_thue + " + txtSoLuong.Text + " WHERE ma_TS = '" + cbxMaTaiSan.SelectedValue + "'";
                ketNoi.Thuc_thi(update);

                MessageBox.Show("Đã Thuê Tài Sản Với Thời Hạn 2 Tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongBao == DialogResult.Yes)
            {
                string delete = "DELETE FROM Hop_dong_thue WHERE ma_hop_dong = '" + txtMaHopDong.Text + "'";
                ketNoi.Thuc_thi(delete);

                string update = "UPDATE Kho_tai_san SET dang_cho_thue = dang_cho_thue - " + txtSoLuong.Text + " WHERE ma_TS = '" + cbxMaTaiSan.SelectedValue + "'";
                ketNoi.Thuc_thi(update);
            }
            else
            { }
            load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMaHopDong.Text.Length != 0)
            {
                DataTable table = new DataTable();
                table = ketNoi.Lay_du_lieu(
                    "SELECT ma_hop_dong,Hop_dong_thue.ma_ho,Hop_dong_thue.ma_TS,so_luong, so_luong * don_gia as thanh_tien,thoi_gian_vao as bat_dau,thoi_gian_ra as ket_thuc " +
                    "FROM Ho_dan,Kho_tai_san,Hop_dong_thue " +
                    "WHERE Ho_dan.ma_ho = Hop_dong_thue.ma_ho AND Kho_tai_san.ma_TS = Hop_dong_thue.ma_TS " +
                    "AND ma_hop_dong = '" + txtMaHopDong.Text + "'");
                dataGridView_HDT.DataSource = table;
                txtMaHopDong.DataBindings.Clear();
                txtMaHopDong.DataBindings.Add("text", dataGridView_HDT.DataSource, "ma_hop_dong");
                txtSoLuong.DataBindings.Clear();
                txtSoLuong.DataBindings.Add("text", dataGridView_HDT.DataSource, "so_luong");
                btnDelete.Enabled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu(
                "SELECT ma_hop_dong,Hop_dong_thue.ma_ho,Hop_dong_thue.ma_TS,so_luong, so_luong * don_gia as thanh_tien,thoi_gian_vao as bat_dau,thoi_gian_ra as ket_thuc " +
                "FROM Ho_dan,Kho_tai_san,Hop_dong_thue " +
                "WHERE Ho_dan.ma_ho = Hop_dong_thue.ma_ho AND Kho_tai_san.ma_TS = Hop_dong_thue.ma_TS " +
                "AND thoi_gian_ra <= '" + now.ToString("yyyy-MM-dd") + "'");
            dataGridView_HDT.DataSource = table;
        }
    }
}
