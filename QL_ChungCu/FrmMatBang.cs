using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QL_ChungCu
{
    public partial class FrmMatBang : Form
    {
        public FrmMatBang()
        {
            InitializeComponent();
        }

        KetNoi ketNoi = new KetNoi();

        /*public void binding()
        {
            cbxMaMatBang.DataBindings.Clear();
            cbxMaMatBang.DataBindings.Add("text", dataGridView_MB.DataSource, "ma_MB");
            txtDienTich.DataBindings.Clear();
            txtDienTich.DataBindings.Add("text", dataGridView_MB.DataSource, "dien_tich");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("text", dataGridView_MB.DataSource, "don_gia");
            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("text", dataGridView_MB.DataSource, "trang_thai");
        }
        */

        public void get_mat_bang()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT * FROM Mat_bang");
            cbxMaMatBang.DataSource = table;
            cbxMaMatBang.DisplayMember = "ma_MB";
            cbxMaMatBang.ValueMember = "ma_MB";
            dataGridView_MB.DataSource = table;
        }

        public void load()
        {
            get_mat_bang();
        }

        private void FrmMatBang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Bạn Có Muốn Sửa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongBao == DialogResult.Yes)
            {
                string update = "UPDATE Mat_bang SET dien_tich = '" + txtDienTich.Text + "', don_gia = '" + txtDonGia.Text + "', trang_thai = '" + txtTrangThai.Text + "' WHERE ma_mb = '" + cbxMaMatBang.SelectedValue +"'";
                ketNoi.Thuc_thi(update);
            }
            else
            { }
            load();
        }


        

        private void cbxMaMatBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Mat_bang WHERE ma_MB = '" + cbxMaMatBang.Text + "'", ketNoi.conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbxMaMatBang.Text = (string)reader["ma_MB"].ToString();
                txtDienTich.Text = (string)reader["dien_tich"].ToString();
                txtDonGia.Text = (string)reader["don_gia"].ToString();
                txtTrangThai.Text = (string)reader["trang_thai"].ToString();
            }
            reader.Close();
            
        }

       
    }
}
