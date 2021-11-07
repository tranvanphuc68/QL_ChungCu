using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ChungCu
{
    public partial class FrmThongTinDichVu : Form
    {
        public FrmThongTinDichVu()
        {
            InitializeComponent();
        }

        KetNoi conn = new KetNoi();
        public void Load_TTDichVu()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select ma_DV as 'Mã dịch vụ', ten_DV as 'Tên dịch vụ', don_gia as 'Đơn giá', don_vi as 'Đơn vị' from Thong_tin_dich_vu");
            dtGridViewTTDV.DataSource = table;

        }

        public void Load_HienThi()
        {
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("text", dtGridViewTTDV.DataSource, "Mã dịch vụ");
            txtTenDV.DataBindings.Clear();
            txtTenDV.DataBindings.Add("text", dtGridViewTTDV.DataSource, "Tên dịch vụ");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("text", dtGridViewTTDV.DataSource, "Đơn giá");
            txtDonVi.DataBindings.Clear();
            txtDonVi.DataBindings.Add("text", dtGridViewTTDV.DataSource, "Đơn vị");
        }

        private void FrmThongTinDichVu_Load(object sender, EventArgs e)
        {

            Load_TTDichVu();

        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tb == System.Windows.Forms.DialogResult.Yes)
            {
                conn.Thuc_thi("Delete Thong_tin_dich_vu Where ma_DV = '" + txtMaDV.Text + "'");
            }
            Load_TTDichVu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if (txtMaDV.Text.Length == 0 && txtTenDV.Text.Length != 0)
            {
                table = conn.Lay_du_lieu("Select ma_DV as 'Mã dịch vụ', ten_DV as 'Tên dịch vụ', don_gia as 'Đơn giá', don_vi as 'Đơn vị' from Thong_tin_dich_vu where ten_DV LIKE '%" + txtTenDV.Text + "%' ");
            }
            else if (txtTenDV.Text.Length == 0)
            {
                table = conn.Lay_du_lieu("Select ma_DV as 'Mã dịch vụ', ten_DV as 'Tên dịch vụ', don_gia as 'Đơn giá', don_vi as 'Đơn vị' from Thong_tin_dich_vu where ma_DV LIKE '%" + txtMaDV.Text + "%'");
            }
            else
            {
                table = conn.Lay_du_lieu("Select ma_DV as 'Mã dịch vụ', ten_DV as 'Tên dịch vụ', don_gia as 'Đơn giá', don_vi as 'Đơn vị' from Thong_tin_dich_vu where ma_DV LIKE '%" + txtMaDV.Text + "%' or ten_DV LIKE '%" + txtTenDV.Text + "%'");

            }
            txtDonGia.Text = txtDonVi.Text = "";
            dtGridViewTTDV.DataSource = table;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_TTDichVu();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text.Length == 0)
            {
                conn.Thuc_thi("Insert into Thong_tin_dich_vu(ten_DV, don_gia, don_vi) values('" + txtTenDV.Text + "', '" + txtDonGia.Text + "','" + txtDonVi.Text + "')");
            }
            else
            {
                conn.Thuc_thi("Insert into Thong_tin_dich_vu values('" + txtMaDV.Text + "' ,'" + txtTenDV.Text + "', '" + txtDonGia.Text + "','" + txtDonVi.Text + "')");
            }
            
            Load_TTDichVu();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Thuc_thi("Update Thong_tin_dich_vu set ten_DV = '" + txtTenDV.Text + "' ,don_gia = '" + txtDonGia.Text + "', don_vi = '" + txtDonVi.Text + "' where ma_DV = '" + txtMaDV.Text + "'");
          
            Load_TTDichVu();
            
        }

        private void dtGridViewTTDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_HienThi();
        }

    }
}
