
namespace QL_ChungCu
{
    partial class FrmKhoTaiSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhoTaiSan));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView_KTS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtCoTheThue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMaTaiSan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtDangChoThue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNhapKho = new System.Windows.Forms.TextBox();
            this.btnNhapKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KTS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(756, 187);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView_KTS
            // 
            this.dataGridView_KTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KTS.Location = new System.Drawing.Point(57, 245);
            this.dataGridView_KTS.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_KTS.Name = "dataGridView_KTS";
            this.dataGridView_KTS.RowHeadersWidth = 51;
            this.dataGridView_KTS.Size = new System.Drawing.Size(993, 276);
            this.dataGridView_KTS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(425, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "                   ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 37);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Có thể thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(52, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã tài sản:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDonGia.Location = new System.Drawing.Point(260, 97);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(160, 34);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = resources.GetString("txtDonGia.Text");
            // 
            // txtCoTheThue
            // 
            this.txtCoTheThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCoTheThue.Location = new System.Drawing.Point(260, 140);
            this.txtCoTheThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoTheThue.Name = "txtCoTheThue";
            this.txtCoTheThue.ReadOnly = true;
            this.txtCoTheThue.Size = new System.Drawing.Size(160, 34);
            this.txtCoTheThue.TabIndex = 4;
            this.txtCoTheThue.Text = resources.GetString("txtCoTheThue.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(377, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "KHO TÀI SẢN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(511, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên tài sản:";
            // 
            // cbxMaTaiSan
            // 
            this.cbxMaTaiSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxMaTaiSan.FormattingEnabled = true;
            this.cbxMaTaiSan.Location = new System.Drawing.Point(260, 55);
            this.cbxMaTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMaTaiSan.Name = "cbxMaTaiSan";
            this.cbxMaTaiSan.Size = new System.Drawing.Size(160, 37);
            this.cbxMaTaiSan.TabIndex = 3;
            this.cbxMaTaiSan.SelectedIndexChanged += new System.EventHandler(this.cbxMaTaiSan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(516, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn vị tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(516, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đang cho thuê:";
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenTaiSan.Location = new System.Drawing.Point(756, 54);
            this.txtTenTaiSan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(132, 34);
            this.txtTenTaiSan.TabIndex = 4;
            this.txtTenTaiSan.Text = resources.GetString("txtTenTaiSan.Text");
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDonViTinh.Location = new System.Drawing.Point(756, 97);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(132, 34);
            this.txtDonViTinh.TabIndex = 4;
            this.txtDonViTinh.Text = resources.GetString("txtDonViTinh.Text");
            // 
            // txtDangChoThue
            // 
            this.txtDangChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDangChoThue.Location = new System.Drawing.Point(756, 140);
            this.txtDangChoThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtDangChoThue.Name = "txtDangChoThue";
            this.txtDangChoThue.ReadOnly = true;
            this.txtDangChoThue.Size = new System.Drawing.Size(132, 34);
            this.txtDangChoThue.TabIndex = 4;
            this.txtDangChoThue.Text = resources.GetString("txtDangChoThue.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(52, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhập kho:";
            // 
            // txtNhapKho
            // 
            this.txtNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNhapKho.Location = new System.Drawing.Point(260, 187);
            this.txtNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapKho.Name = "txtNhapKho";
            this.txtNhapKho.Size = new System.Drawing.Size(160, 34);
            this.txtNhapKho.TabIndex = 4;
            this.txtNhapKho.Text = resources.GetString("txtNhapKho.Text");
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNhapKho.Location = new System.Drawing.Point(516, 187);
            this.btnNhapKho.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(137, 36);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // FrmKhoTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtDangChoThue);
            this.Controls.Add(this.txtNhapKho);
            this.Controls.Add(this.txtCoTheThue);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbxMaTaiSan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_KTS);
            this.Controls.Add(this.btnNhapKho);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmKhoTaiSan";
            this.Text = "KHO TÀI SẢN";
            this.Load += new System.EventHandler(this.FrmKhoTaiSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView_KTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtCoTheThue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMaTaiSan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDangChoThue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNhapKho;
        private System.Windows.Forms.Button btnNhapKho;
    }
}