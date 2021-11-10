using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_ChungCu
{
    public partial class FrmQUANLY : Form
    {
        private int childFormNumber = 0;

        public FrmQUANLY()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void hỘDÂNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHoDan frm = new FrmHoDan();
            frm.Show();
        }

        private void dÂNCƯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanCu frm = new FrmDanCu();
            frm.Show();
        }

        private void mẶTBẰNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatBang frm = new FrmMatBang();
            frm.Show();
        }

        private void đĂNGKÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDichVuDangKy frm = new FrmDichVuDangKy();
            frm.Show();
        }

        private void tHANHTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThanhToanDichVu frm = new FrmThanhToanDichVu();
            frm.Show();
        }

        private void tHÔNGTINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinDichVu frm = new FrmThongTinDichVu();
            frm.Show();
        }

        private void kHOTÀISẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoTaiSan frm = new FrmKhoTaiSan();
            frm.Show();
        }

        private void hỢPĐỒNGTHUÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHopDongThue frm = new FrmHopDongThue();
            frm.Show();
        }

        private void bÃIXEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaiDoXe frm = new FrmBaiDoXe();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDichVuDangKy frm = new FrmDichVuDangKy();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHopDongThue frm = new FrmHopDongThue();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBaiDoXe frm = new FrmBaiDoXe();
            frm.Show();
        }

        private void dỊCHVỤĐIỆNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRPDien frm = new FrmRPDien();
            frm.Show();
        }

        private void dỊCHVỤNƯỚCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRPNuoc frm = new FrmRPNuoc();
            frm.Show();
        }

        private void kHOTÀISẢNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRPKhoTaiSan frm = new FrmRPKhoTaiSan();
            frm.Show();
        }

        private void hỘDÂNToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRPHoDan frm = new FrmRPHoDan();
            frm.Show();
        }

        private void dỊCHVỤTHUÊTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRPThueTaiSan frm = new FrmRPThueTaiSan();
            frm.Show();
        }
    }
}
