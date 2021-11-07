
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
            this.btnUpdate.Location = new System.Drawing.Point(567, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 29);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView_KTS
            // 
            this.dataGridView_KTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KTS.Location = new System.Drawing.Point(43, 199);
            this.dataGridView_KTS.Name = "dataGridView_KTS";
            this.dataGridView_KTS.Size = new System.Drawing.Size(745, 179);
            this.dataGridView_KTS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "                   ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Có thể thuê:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(39, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã tài sản:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDonGia.Location = new System.Drawing.Point(195, 79);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(121, 29);
            this.txtDonGia.TabIndex = 4;
            this.txtDonGia.Text = resources.GetString("txtDonGia.Text");
            // 
            // txtCoTheThue
            // 
            this.txtCoTheThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCoTheThue.Location = new System.Drawing.Point(195, 114);
            this.txtCoTheThue.Name = "txtCoTheThue";
            this.txtCoTheThue.ReadOnly = true;
            this.txtCoTheThue.Size = new System.Drawing.Size(121, 29);
            this.txtCoTheThue.TabIndex = 4;
            this.txtCoTheThue.Text = resources.GetString("txtCoTheThue.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(283, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "KHO TÀI SẢN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(383, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên tài sản:";
            // 
            // cbxMaTaiSan
            // 
            this.cbxMaTaiSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbxMaTaiSan.FormattingEnabled = true;
            this.cbxMaTaiSan.Location = new System.Drawing.Point(195, 42);
            this.cbxMaTaiSan.Name = "cbxMaTaiSan";
            this.cbxMaTaiSan.Size = new System.Drawing.Size(121, 32);
            this.cbxMaTaiSan.TabIndex = 3;
            this.cbxMaTaiSan.SelectedIndexChanged += new System.EventHandler(this.cbxMaTaiSan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(387, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Đơn vị tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(387, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Đang cho thuê:";
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTenTaiSan.Location = new System.Drawing.Point(567, 44);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(100, 29);
            this.txtTenTaiSan.TabIndex = 4;
            this.txtTenTaiSan.Text = resources.GetString("txtTenTaiSan.Text");
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDonViTinh.Location = new System.Drawing.Point(567, 79);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 29);
            this.txtDonViTinh.TabIndex = 4;
            this.txtDonViTinh.Text = resources.GetString("txtDonViTinh.Text");
            // 
            // txtDangChoThue
            // 
            this.txtDangChoThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDangChoThue.Location = new System.Drawing.Point(567, 114);
            this.txtDangChoThue.Name = "txtDangChoThue";
            this.txtDangChoThue.ReadOnly = true;
            this.txtDangChoThue.Size = new System.Drawing.Size(100, 29);
            this.txtDangChoThue.TabIndex = 4;
            this.txtDangChoThue.Text = resources.GetString("txtDangChoThue.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(39, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nhập kho:";
            // 
            // txtNhapKho
            // 
            this.txtNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNhapKho.Location = new System.Drawing.Point(195, 152);
            this.txtNhapKho.Name = "txtNhapKho";
            this.txtNhapKho.Size = new System.Drawing.Size(121, 29);
            this.txtNhapKho.TabIndex = 4;
            this.txtNhapKho.Text = resources.GetString("txtNhapKho.Text");
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNhapKho.Location = new System.Drawing.Point(387, 152);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(103, 29);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // FrmKhoTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmKhoTaiSan";
            this.Text = "FrmKhoTaiSan";
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