using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_ChungCu
{
    public partial class FrmKhoTaiSan : Form
    {
        public FrmKhoTaiSan()
        {
            InitializeComponent();
        }

        KetNoi ketNoi = new KetNoi();

        

        public void get_kho_tai_san()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT ma_TS,ten_TS,don_gia,don_vi,nhap_kho - dang_cho_thue as co_the_thue,dang_cho_thue,nhap_kho as tong_so_luong FROM Kho_tai_san");
            cbxMaTaiSan.DataSource = table;
            cbxMaTaiSan.DisplayMember = "ma_TS";
            cbxMaTaiSan.ValueMember = "ma_TS";
            dataGridView_KTS.DataSource = table;
        }
        public void load()
        {
            get_kho_tai_san();
            txtNhapKho.Text = "";
        }
        private void FrmKhoTaiSan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Bạn Có Muốn Sửa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongBao == DialogResult.Yes)
            {
                string update = "UPDATE Kho_tai_san SET ten_TS = '" + txtTenTaiSan.Text + "', don_vi = '" + txtDonViTinh.Text + "', don_gia = '" + txtDonGia.Text + "' WHERE ma_TS = '" + cbxMaTaiSan.SelectedValue + "'";
                ketNoi.Thuc_thi(update);
            }
            else
            { }
            load();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Bạn Có Muốn Nhập Kho Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongBao == DialogResult.Yes)
            {
                string update = "UPDATE Kho_tai_san SET nhap_kho = nhap_kho + " + txtNhapKho.Text + " WHERE ma_TS = '" + cbxMaTaiSan.SelectedValue + "'";
                ketNoi.Thuc_thi(update);
            }
            else
            { }
            load();
        }

        private void cbxMaTaiSan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT ma_TS,ten_TS,don_gia,nhap_kho - dang_cho_thue as co_the_thue,dang_cho_thue,don_vi FROM Kho_tai_san WHERE ma_TS = '" + cbxMaTaiSan.Text + "'", ketNoi.conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtTenTaiSan.Text = (string)reader["ten_TS"].ToString();
                txtCoTheThue.Text = (string)reader["co_the_thue"].ToString();
                txtDangChoThue.Text = (string)reader["dang_cho_thue"].ToString();
                txtDonGia.Text = (string)reader["don_gia"].ToString();
                txtDonViTinh.Text = (string)reader["don_vi"].ToString();
            }
            reader.Close();
        }
    }
}
