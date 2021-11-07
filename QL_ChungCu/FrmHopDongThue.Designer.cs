
namespace QL_ChungCu
{
    partial class FrmHopDongThue
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.txtCoTheThue = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.dataGridView_HDT = new System.Windows.Forms.DataGridView();
            this.cbxMaTaiSan = new System.Windows.Forms.ComboBox();
            this.cbxMaHo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDT)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(19, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mã hợp đồng:";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMaHopDong.Location = new System.Drawing.Point(205, 62);
            this.txtMaHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(160, 34);
            this.txtMaHopDong.TabIndex = 27;
            // 
            // txtCoTheThue
            // 
            this.txtCoTheThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCoTheThue.Location = new System.Drawing.Point(568, 176);
            this.txtCoTheThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoTheThue.Name = "txtCoTheThue";
            this.txtCoTheThue.ReadOnly = true;
            this.txtCoTheThue.Size = new System.Drawing.Size(160, 34);
            this.txtCoTheThue.TabIndex = 26;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtThanhTien.Location = new System.Drawing.Point(205, 180);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(160, 34);
            this.txtThanhTien.TabIndex = 25;
            // 
            // dataGridView_HDT
            // 
            this.dataGridView_HDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HDT.Location = new System.Drawing.Point(12, 289);
            this.dataGridView_HDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_HDT.Name = "dataGridView_HDT";
            this.dataGridView_HDT.ReadOnly = true;
            this.dataGridView_HDT.RowHeadersWidth = 51;
            this.dataGridView_HDT.Size = new System.Drawing.Size(1042, 229);
            this.dataGridView_HDT.TabIndex = 24;
            // 
            // cbxMaTaiSan
            // 
            this.cbxMaTaiSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxMaTaiSan.FormattingEnabled = true;
            this.cbxMaTaiSan.Location = new System.Drawing.Point(568, 58);
            this.cbxMaTaiSan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMaTaiSan.Name = "cbxMaTaiSan";
            this.cbxMaTaiSan.Size = new System.Drawing.Size(160, 37);
            this.cbxMaTaiSan.TabIndex = 23;
            this.cbxMaTaiSan.SelectedIndexChanged += new System.EventHandler(this.cbxMaTaiSan_SelectedIndexChanged);
            // 
            // cbxMaHo
            // 
            this.cbxMaHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxMaHo.FormattingEnabled = true;
            this.cbxMaHo.Location = new System.Drawing.Point(205, 230);
            this.cbxMaHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMaHo.Name = "cbxMaHo";
            this.cbxMaHo.Size = new System.Drawing.Size(160, 37);
            this.cbxMaHo.TabIndex = 22;
            this.cbxMaHo.SelectedIndexChanged += new System.EventHandler(this.cbxMaHo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(409, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tên tài sản:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(409, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "Có thể thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(409, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên chủ hộ:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblThanhTien.Location = new System.Drawing.Point(255, 289);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(0, 29);
            this.lblThanhTien.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(19, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 29);
            this.label9.TabIndex = 17;
            this.label9.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(19, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(409, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mã tài sản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(19, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã hộ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(369, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "HỢP ĐỒNG THUÊ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(905, 235);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnThue
            // 
            this.btnThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThue.Location = new System.Drawing.Point(779, 121);
            this.btnThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(100, 36);
            this.btnThue.TabIndex = 11;
            this.btnThue.Text = "Thuê";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenTaiSan.Location = new System.Drawing.Point(568, 122);
            this.txtTenTaiSan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.ReadOnly = true;
            this.txtTenTaiSan.Size = new System.Drawing.Size(160, 34);
            this.txtTenTaiSan.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSoLuong.Location = new System.Drawing.Point(205, 122);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 34);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenChuHo.Location = new System.Drawing.Point(568, 233);
            this.txtTenChuHo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.ReadOnly = true;
            this.txtTenChuHo.Size = new System.Drawing.Size(288, 34);
            this.txtTenChuHo.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDonGia.Location = new System.Drawing.Point(856, 59);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(148, 34);
            this.txtDonGia.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(741, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Đơn giá:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(905, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnView
            // 
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnView.Location = new System.Drawing.Point(905, 176);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 36);
            this.btnView.TabIndex = 30;
            this.btnView.Text = "Hiển thị";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(779, 176);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 36);
            this.btnCheck.TabIndex = 31;
            this.btnCheck.Text = "Hết hạn";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FrmHopDongThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.txtCoTheThue);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.dataGridView_HDT);
            this.Controls.Add(this.cbxMaTaiSan);
            this.Controls.Add(this.cbxMaHo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenChuHo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHopDongThue";
            this.Text = "FrmHopDongThue";
            this.Load += new System.EventHandler(this.FrmHopDongThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HDT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.TextBox txtCoTheThue;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.DataGridView dataGridView_HDT;
        private System.Windows.Forms.ComboBox cbxMaTaiSan;
        private System.Windows.Forms.ComboBox cbxMaHo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCheck;
    }
}