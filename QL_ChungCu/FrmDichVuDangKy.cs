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
    public partial class FrmDichVuDangKy : Form
    {
        public FrmDichVuDangKy()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();

        string dtb = new KetNoi().dtb;
        SqlConnection connect;
        public void Load_DanCu()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("SELECT ma_HD_DV as 'Mã hợp đồng', trang_thai, Ho_dan.ma_ho as 'Mã hộ dân', ten_chu_ho as 'Chủ hộ', ten_DV as 'Dịch vụ', thang as 'Tháng', nam as 'Năm', CASE trang_thai WHEN '0' THEN 'Van su dung' WHEN '1' THEN 'Huy thang toi' END as 'Trạng thái' " +
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
            chbStatus.DataBindings.Clear();
            chbStatus.DataBindings.Add("checked", dtGridViewDV.DataSource, "trang_thai");
        }

        public void Load_all()
        {
            Load_DanCu();
            Load_MaHo();
            Load_MaDV();
            Load_Thang();
            Load_Nam();
            txtMaHDDV.Hide();
            dtGridViewDV.Columns[0].Visible = false;
            dtGridViewDV.Columns[1].Visible = false;

        }

        public void auto_CreateDV()
        {
            connect = new SqlConnection(dtb);
            connect.Open();
            int month;
            int year;
            if (DateTime.Now.Month == 1)
            {
                month = 12;
                year = DateTime.Now.Year - 1;
            }
            else {
                month = DateTime.Now.Month - 1;
                year = DateTime.Now.Year;
            }
            

            if (DateTime.Now.Day == 8)
            {
                string query = "SELECT ma_ho, ma_DV FROM Dich_vu WHERE thang = '"+ month + "' AND nam = '" + year + "' AND trang_thai = 0";
                DataTable table = conn.Lay_du_lieu(query);
                foreach ( DataRow row in table.Rows)
                    {
                        string ma_ho = row["ma_ho"].ToString();
                        string ma_DV = row["ma_DV"].ToString();
                        string query1 = "SELECT COUNT(*) FROM Dich_vu WHERE thang = MONTH(GETDATE()) AND nam = YEAR(GETDATE()) AND trang_thai = 0 AND ma_ho = '" + ma_ho + "'AND ma_DV = '" + ma_DV + "'";
                        SqlCommand cmd = new SqlCommand(query1,connect);
                        int count = (Int32)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            conn.Thuc_thi("Insert into Dich_vu( ma_ho, ma_DV, thang, nam) " +
                                    "values('" + ma_ho + "', '" + ma_DV + "', MONTH(GETDATE()),YEAR(GETDATE()))");
                        }
                    }
                     
                        
                    
             }
                
         
        }

        private void FrmDichVuDangKy_Load(object sender, EventArgs e)
        {

            Load_all();
            auto_CreateDV();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            conn.Thuc_thi("Insert into Dich_vu(ma_ho, ma_DV, thang, nam) values('" + cbbMaHo.SelectedValue + "', '" + cbbDV.SelectedValue + "', MONTH(GETDATE()),YEAR(GETDATE()))");
            
            Load_all();
        }
        

        private void btnDel_Click(object sender, EventArgs e)
        {
            conn.Thuc_thi("Delete Dich_vu Where ma_HD_DV = '" + txtMaHDDV.Text + "'");
            Load_all();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table = conn.Lay_du_lieu("Select ma_HD_DV as 'Mã hợp đồng', thanh_toan, Ho_dan.ma_ho as 'Mã hộ dân', ten_chu_ho as 'Chủ hộ', ten_DV as 'Dịch vụ', thang as 'Tháng', nam as 'Năm', CASE trang_thai WHEN '0' THEN 'Van su dung' WHEN '1' THEN 'Huy thang toi' END as 'Trạng thái' " +
                "FROM Thong_tin_dich_vu, Dich_vu, Ho_dan " +
                "WHERE Dich_vu.ma_DV = Thong_tin_dich_vu.ma_DV AND Ho_dan.ma_ho = Dich_vu.ma_ho " +
                    "AND ten_DV LIKE '%" + cbbDV.Text + "%' " +
                    "AND Ho_dan.ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%' " +
                    "AND thang LIKE '%" + cbbMonth.SelectedValue + "%' " +
                    "AND nam LIKE '%" + cbbYear.SelectedValue + "%'");
            dtGridViewDV.DataSource = table;
            txtMaHDDV.Hide();
            dtGridViewDV.Columns[0].Visible = false;
            dtGridViewDV.Columns[1].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(chbStatus.Checked == true)
            {
                string check = (string)cbbDV.SelectedValue;
                if (check == "DV001" || check == "DV002")
                {
                    MessageBox.Show("Không thể ngừng dịch vụ này");

                }
                else
                {
                    conn.Thuc_thi("UPDATE Dich_vu SET trang_thai = '1' WHERE ma_HD_DV = '" + txtMaHDDV.Text + "'");
                }
                
            } else
                {
                    conn.Thuc_thi("UPDATE Dich_vu SET trang_thai = '0' WHERE ma_HD_DV = '" + txtMaHDDV.Text + "'");
                }    
            
            Load_all();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            FrmThanhToanDichVu ttdv = new FrmThanhToanDichVu();
            ttdv.ShowDialog();
        }

        private void cbbMaHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            connect = new SqlConnection(dtb);
            connect.Open();

            string query = "SELECT ten_chu_ho FROM Ho_dan WHERE ma_ho = '" + cbbMaHo.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(query,connect);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = (string)reader["ten_chu_ho"].ToString();
                txtChuHo.Text = name;
            }
        }

        private void dtGridViewDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_HienThi();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_all();
        }
    }
}
