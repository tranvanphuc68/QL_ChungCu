
namespace QL_ChungCu
{
    partial class FrmBaiDoXe
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
            this.viewIn = new System.Windows.Forms.DataGridView();
            this.xeVao = new System.Windows.Forms.Button();
            this.xeRa = new System.Windows.Forms.Button();
            this.uid = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkUID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewOut = new System.Windows.Forms.DataGridView();
            this.checkID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkXeRa = new System.Windows.Forms.Button();
            this.checkType = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewExample = new System.Windows.Forms.DataGridView();
            this.Motor = new System.Windows.Forms.TextBox();
            this.Car = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOut)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewExample)).BeginInit();
            this.SuspendLayout();
            // 
            // viewIn
            // 
            this.viewIn.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.viewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewIn.Location = new System.Drawing.Point(16, 106);
            this.viewIn.Margin = new System.Windows.Forms.Padding(4);
            this.viewIn.Name = "viewIn";
            this.viewIn.ReadOnly = true;
            this.viewIn.RowHeadersWidth = 51;
            this.viewIn.Size = new System.Drawing.Size(755, 279);
            this.viewIn.TabIndex = 0;
            // 
            // xeVao
            // 
            this.xeVao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xeVao.Location = new System.Drawing.Point(135, 144);
            this.xeVao.Margin = new System.Windows.Forms.Padding(4);
            this.xeVao.Name = "xeVao";
            this.xeVao.Size = new System.Drawing.Size(161, 48);
            this.xeVao.TabIndex = 1;
            this.xeVao.Text = "Xe Vào";
            this.xeVao.UseVisualStyleBackColor = true;
            this.xeVao.Click += new System.EventHandler(this.xeVao_Click);
            // 
            // xeRa
            // 
            this.xeRa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xeRa.Location = new System.Drawing.Point(135, 63);
            this.xeRa.Margin = new System.Windows.Forms.Padding(4);
            this.xeRa.Name = "xeRa";
            this.xeRa.Size = new System.Drawing.Size(161, 50);
            this.xeRa.TabIndex = 2;
            this.xeRa.Text = "Xe Ra";
            this.xeRa.UseVisualStyleBackColor = true;
            this.xeRa.Click += new System.EventHandler(this.xeRa_Click);
            // 
            // uid
            // 
            this.uid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.Location = new System.Drawing.Point(135, 23);
            this.uid.Margin = new System.Windows.Forms.Padding(4);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(160, 30);
            this.uid.TabIndex = 6;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(135, 63);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(160, 30);
            this.id.TabIndex = 7;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Xe máy",
            "Ô tô"});
            this.type.Location = new System.Drawing.Point(135, 103);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(160, 30);
            this.type.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "UID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "TYPE";
            // 
            // checkUID
            // 
            this.checkUID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUID.Location = new System.Drawing.Point(135, 21);
            this.checkUID.Margin = new System.Windows.Forms.Padding(4);
            this.checkUID.Name = "checkUID";
            this.checkUID.Size = new System.Drawing.Size(160, 30);
            this.checkUID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "UID";
            // 
            // viewOut
            // 
            this.viewOut.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.viewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOut.Location = new System.Drawing.Point(16, 421);
            this.viewOut.Margin = new System.Windows.Forms.Padding(4);
            this.viewOut.Name = "viewOut";
            this.viewOut.ReadOnly = true;
            this.viewOut.RowHeadersWidth = 51;
            this.viewOut.Size = new System.Drawing.Size(755, 239);
            this.viewOut.TabIndex = 14;
            // 
            // checkID
            // 
            this.checkID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkID.Location = new System.Drawing.Point(135, 119);
            this.checkID.Margin = new System.Windows.Forms.Padding(4);
            this.checkID.Name = "checkID";
            this.checkID.ReadOnly = true;
            this.checkID.Size = new System.Drawing.Size(160, 30);
            this.checkID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // checkFee
            // 
            this.checkFee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFee.Location = new System.Drawing.Point(135, 202);
            this.checkFee.Margin = new System.Windows.Forms.Padding(4);
            this.checkFee.Name = "checkFee";
            this.checkFee.ReadOnly = true;
            this.checkFee.Size = new System.Drawing.Size(160, 30);
            this.checkFee.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "FEE";
            // 
            // checkXeRa
            // 
            this.checkXeRa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXeRa.Location = new System.Drawing.Point(135, 249);
            this.checkXeRa.Margin = new System.Windows.Forms.Padding(4);
            this.checkXeRa.Name = "checkXeRa";
            this.checkXeRa.Size = new System.Drawing.Size(161, 50);
            this.checkXeRa.TabIndex = 21;
            this.checkXeRa.Text = "Xác Nhận";
            this.checkXeRa.UseVisualStyleBackColor = true;
            this.checkXeRa.Click += new System.EventHandler(this.checkXeRa_Click);
            // 
            // checkType
            // 
            this.checkType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkType.Location = new System.Drawing.Point(135, 162);
            this.checkType.Margin = new System.Windows.Forms.Padding(4);
            this.checkType.Name = "checkType";
            this.checkType.ReadOnly = true;
            this.checkType.Size = new System.Drawing.Size(160, 30);
            this.checkType.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.uid);
            this.panel1.Controls.Add(this.xeVao);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.type);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(787, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 212);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.viewExample);
            this.panel2.Controls.Add(this.checkUID);
            this.panel2.Controls.Add(this.xeRa);
            this.panel2.Controls.Add(this.checkType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkXeRa);
            this.panel2.Controls.Add(this.checkID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.checkFee);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(787, 353);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 306);
            this.panel2.TabIndex = 24;
            // 
            // viewExample
            // 
            this.viewExample.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewExample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewExample.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewExample.Location = new System.Drawing.Point(329, 294);
            this.viewExample.Margin = new System.Windows.Forms.Padding(4);
            this.viewExample.Name = "viewExample";
            this.viewExample.ReadOnly = true;
            this.viewExample.RowHeadersWidth = 51;
            this.viewExample.Size = new System.Drawing.Size(13, 12);
            this.viewExample.TabIndex = 27;
            // 
            // Motor
            // 
            this.Motor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motor.ForeColor = System.Drawing.Color.Red;
            this.Motor.Location = new System.Drawing.Point(580, 15);
            this.Motor.Margin = new System.Windows.Forms.Padding(4);
            this.Motor.Name = "Motor";
            this.Motor.Size = new System.Drawing.Size(132, 34);
            this.Motor.TabIndex = 25;
            // 
            // Car
            // 
            this.Car.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car.ForeColor = System.Drawing.Color.Red;
            this.Car.Location = new System.Drawing.Point(199, 17);
            this.Car.Margin = new System.Windows.Forms.Padding(4);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(131, 34);
            this.Car.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "BÃI Ô TÔ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 31);
            this.label9.TabIndex = 28;
            this.label9.Text = "BÃI XE MÁY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(245, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "DANH SÁCH XE VÀO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 385);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "DANH SÁCH XE RA";
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1152, 678);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.Motor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewOut);
            this.Controls.Add(this.viewIn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLy";
            this.Text = "Quản Lý Bãi";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewIn;
        private System.Windows.Forms.Button xeVao;
        private System.Windows.Forms.Button xeRa;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox checkUID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView viewOut;
        private System.Windows.Forms.TextBox checkID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox checkFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button checkXeRa;
        private System.Windows.Forms.TextBox checkType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Motor;
        private System.Windows.Forms.TextBox Car;
        private System.Windows.Forms.DataGridView viewExample;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}