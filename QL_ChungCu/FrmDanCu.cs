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
    public partial class FrmDanCu : Form
    {
        public FrmDanCu()
        {
            InitializeComponent();
        }
        KetNoi conn = new KetNoi();
        public void Load_DanCu()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select ma_ho as 'Mã hộ dân', ma_DC as 'Mã dân cư', ho_ten as 'Họ tên' from Dan_cu");
            dtGridViewDC.DataSource = table;

        }

        public void Load_MaHo()
        {
            DataTable table = new DataTable();
            table = conn.Lay_du_lieu("Select* from Ho_dan");
            cbbMaHo.DataSource = table;
            cbbMaHo.DisplayMember = "ma_ho";
            cbbMaHo.ValueMember = "ma_ho";

        }
        public void Load_HienThi()
        {
            txtMaDC.DataBindings.Clear();
            txtMaDC.DataBindings.Add("text", dtGridViewDC.DataSource, "Mã dân cư");
            txtDanCu.DataBindings.Clear();
            txtDanCu.DataBindings.Add("text", dtGridViewDC.DataSource, "Họ tên");
            cbbMaHo.DataBindings.Clear();
            cbbMaHo.DataBindings.Add("text", dtGridViewDC.DataSource, "Mã hộ dân");
        }

        public void Load_all()
        {
            Load_DanCu();
            Load_MaHo();
            
        }
        private void FrmDanCu_Load(object sender, EventArgs e)
        {
            Load_all();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtMaDC.Text.Length == 0)
            {
                conn.Thuc_thi("Insert into Dan_cu(ma_ho, ho_ten) values ('" + cbbMaHo.SelectedValue + "',' " + txtDanCu.Text + "')");
            }
            else
                conn.Thuc_thi("Insert into Dan_cu values('" + txtMaDC.Text + "' ,'" + cbbMaHo.SelectedValue + "', '" + txtDanCu.Text + "')");
            Load_all();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Thuc_thi("Update Dan_cu set ma_ho = '" + cbbMaHo.SelectedValue + "' , ho_ten = '" + txtDanCu.Text + "' where ma_DC = '" + txtMaDC.Text + "'");
            Load_all();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tb == System.Windows.Forms.DialogResult.Yes)
            {
                conn.Thuc_thi("Delete Dan_cu Where ma_DC = '" + txtMaDC.Text + "'");
            }
            Load_all();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            if ((txtDanCu.Text.Length == 0) && (txtMaDC.Text.Length == 0))
            {
                table = conn.Lay_du_lieu("Select ma_ho as 'Mã hộ dân', ma_DC as 'Mã dân cư', ho_ten as 'Họ tên' from Dan_cu where ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%'");
            }
            else if (txtDanCu.Text.Length == 0)
            {
                table = conn.Lay_du_lieu("Select ma_ho as 'Mã hộ dân', ma_DC as 'Mã dân cư', ho_ten as 'Họ tên' from Dan_cu where ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%' or ma_DC LIKE '%" + txtMaDC.Text + "%'");
            }
            else if (txtMaDC.Text.Length == 0)
            {
                table = conn.Lay_du_lieu("Select ma_ho as 'Mã hộ dân', ma_DC as 'Mã dân cư', ho_ten as 'Họ tên' from Dan_cu where ho_ten LIKE '%" + txtDanCu.Text + "%' or ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%'");
            }
            else
            {
                table = conn.Lay_du_lieu("Select ma_ho as 'Mã hộ dân', ma_DC as 'Mã dân cư', ho_ten as 'Họ tên' from Dan_cu where ho_ten LIKE '%" + txtDanCu.Text + "%' or ma_ho LIKE '%" + cbbMaHo.SelectedValue + "%' or ma_DC LIKE '%" + txtMaDC.Text + "%'");

            }
            Load_MaHo();
            dtGridViewDC.DataSource = table;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Load_all();
        }

        private void dtGridViewDC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_HienThi();
        }

    }
}
