using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ChungCu
{
    public partial class FrmHoDan : Form
    {
        public FrmHoDan()
        {
            InitializeComponent();
        }

        KetNoi ketNoi = new KetNoi();
       
        public void get_mat_bang()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT * FROM Mat_bang");
            cbxMaMatBang.DataSource = table;
            cbxMaMatBang.DisplayMember = "ma_MB";
            cbxMaMatBang.ValueMember = "ma_MB";
        }
        public void get_ho_dan()
        {
            DataTable table = new DataTable();
            table = ketNoi.Lay_du_lieu("SELECT * FROM Ho_dan");
            dataGridView_HD.DataSource = table;
        }
        
        public void load()
        {
            get_ho_dan();
            get_mat_bang();
        }
        private void FrmHoDan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string ma_MB = "SELECT ma_MB FROM Ho_dan WHERE ma_MB = '" + cbxMaMatBang.SelectedValue + "'";  
            SqlCommand cmd = new SqlCommand(ma_MB, ketNoi.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Boolean check1 = reader.Read();
            reader.Close();
            cmd = ketNoi.conn.CreateCommand();
            cmd.CommandText = "SELECT ma_ho FROM Ho_dan WHERE ma_ho = '" + txtMaHo.Text + "'";
            reader = cmd.ExecuteReader();
            Boolean check2 = reader.Read();
            
            if (check1 == true)
            {
                MessageBox.Show("Mặt bằng đã có người ở", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check2 == true)
            {
                MessageBox.Show("Mã hộ dân bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else
            {
                string insert = "INSERT INTO Ho_dan(ma_MB,ten_chu_ho) VALUES ('" + cbxMaMatBang.Text + "', '" + txtTenChuHo.Text + "')";
                string update = "UPDATE Mat_bang SET trang_thai = 1 WHERE ma_MB = '" + cbxMaMatBang.Text + "'";
                ketNoi.Thuc_thi(insert);
                ketNoi.Thuc_thi(update);
            }
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thongBao == DialogResult.Yes)
            {
                string detele = "DELETE Ho_dan WHERE ma_ho = '" + txtMaHo.Text + "'";
                string update = "UPDATE Mat_bang SET trang_thai = 0 WHERE ma_MB = '" + cbxMaMatBang.Text + "'";
                ketNoi.Thuc_thi(detele);
                ketNoi.Thuc_thi(update);
            }
            load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = "";
            if (txtTenChuHo.Text.Length == 0)
            {
                search = "SELECT * FROM Ho_dan WHERE ma_ho LIKE '" + txtMaHo.Text + "'";
            }else if (txtMaHo.Text.Length == 0)
            {
                search = "SELECT * FROM Ho_dan WHERE ten_chu_ho LIKE '%" + txtTenChuHo.Text + "%'";
            } 
            else
            {
                search = "SELECT * FROM Ho_dan WHERE ma_ho LIKE '%" + txtMaHo.Text + "%' OR ten_chu_ho LIKE '%" + txtTenChuHo.Text + "%'";
            }
            dataGridView_HD.DataSource = ketNoi.Lay_du_lieu(search);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
