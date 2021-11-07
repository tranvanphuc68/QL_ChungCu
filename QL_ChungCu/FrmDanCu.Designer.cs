
namespace QL_ChungCu
{
    partial class FrmDanCu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDC = new System.Windows.Forms.TextBox();
            this.txtDanCu = new System.Windows.Forms.TextBox();
            this.cbbMaHo = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dtGridViewDC = new System.Windows.Forms.DataGridView();
            this.btnAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hộ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã dân cư:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên dân cư:";
            // 
            // txtMaDC
            // 
            this.txtMaDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDC.Location = new System.Drawing.Point(199, 124);
            this.txtMaDC.Name = "txtMaDC";
            this.txtMaDC.Size = new System.Drawing.Size(127, 34);
            this.txtMaDC.TabIndex = 1;
            // 
            // txtDanCu
            // 
            this.txtDanCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanCu.Location = new System.Drawing.Point(199, 167);
            this.txtDanCu.Name = "txtDanCu";
            this.txtDanCu.Size = new System.Drawing.Size(213, 34);
            this.txtDanCu.TabIndex = 1;
            // 
            // cbbMaHo
            // 
            this.cbbMaHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHo.FormattingEnabled = true;
            this.cbbMaHo.Location = new System.Drawing.Point(198, 76);
            this.cbbMaHo.Name = "cbbMaHo";
            this.cbbMaHo.Size = new System.Drawing.Size(128, 37);
            this.cbbMaHo.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(430, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Location = new System.Drawing.Point(79, 216);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 33);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Thêm Dân cư mới";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(239, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Lưu thay đổi";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDel.Location = new System.Drawing.Point(415, 216);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(137, 33);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xóa dân cư";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dtGridViewDC
            // 
            this.dtGridViewDC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDC.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtGridViewDC.Location = new System.Drawing.Point(33, 255);
            this.dtGridViewDC.Name = "dtGridViewDC";
            this.dtGridViewDC.RowHeadersWidth = 51;
            this.dtGridViewDC.RowTemplate.Height = 24;
            this.dtGridViewDC.Size = new System.Drawing.Size(577, 227);
            this.dtGridViewDC.TabIndex = 4;
            this.dtGridViewDC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewDC_CellContentClick);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAll.Location = new System.Drawing.Point(430, 120);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(122, 39);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "Hiện tất cả";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "DÂN CƯ";
            // 
            // FrmDanCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dtGridViewDC);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbbMaHo);
            this.Controls.Add(this.txtDanCu);
            this.Controls.Add(this.txtMaDC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanCu";
            this.Text = "FrmDanCu";
            this.Load += new System.EventHandler(this.FrmDanCu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDC;
        private System.Windows.Forms.TextBox txtDanCu;
        private System.Windows.Forms.ComboBox cbbMaHo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dtGridViewDC;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label4;
    }
}