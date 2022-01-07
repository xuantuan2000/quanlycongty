
namespace Form_QLCongTy_DoAn
{
    partial class frm_HangHoa
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_xuatxu = new System.Windows.Forms.ListBox();
            this.txt_mshh = new System.Windows.Forms.TextBox();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaynhaphang = new System.Windows.Forms.DateTimePicker();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_tang = new System.Windows.Forms.RadioButton();
            this.rb_giam = new System.Windows.Forms.RadioButton();
            this.dataGridView_hh = new System.Windows.Forms.DataGridView();
            this.MAHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAPHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAQG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_mathang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Số Hàng Hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng Hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(62, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhập hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại Mặt hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá bán:";
            // 
            // lb_xuatxu
            // 
            this.lb_xuatxu.FormattingEnabled = true;
            this.lb_xuatxu.ItemHeight = 15;
            this.lb_xuatxu.Location = new System.Drawing.Point(481, 110);
            this.lb_xuatxu.Name = "lb_xuatxu";
            this.lb_xuatxu.Size = new System.Drawing.Size(151, 64);
            this.lb_xuatxu.TabIndex = 6;
            this.lb_xuatxu.SelectedIndexChanged += new System.EventHandler(this.lb_xuatxu_SelectedIndexChanged);
            // 
            // txt_mshh
            // 
            this.txt_mshh.Location = new System.Drawing.Point(167, 73);
            this.txt_mshh.Name = "txt_mshh";
            this.txt_mshh.Size = new System.Drawing.Size(170, 22);
            this.txt_mshh.TabIndex = 7;
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.Location = new System.Drawing.Point(168, 113);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(170, 22);
            this.txt_tenhang.TabIndex = 8;
            // 
            // dateTimePicker_ngaynhaphang
            // 
            this.dateTimePicker_ngaynhaphang.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngaynhaphang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaynhaphang.Location = new System.Drawing.Point(169, 152);
            this.dateTimePicker_ngaynhaphang.Name = "dateTimePicker_ngaynhaphang";
            this.dateTimePicker_ngaynhaphang.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker_ngaynhaphang.TabIndex = 9;
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(168, 187);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.Size = new System.Drawing.Size(170, 22);
            this.txt_giaban.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "($)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sắp xếp:";
            // 
            // rb_tang
            // 
            this.rb_tang.AutoSize = true;
            this.rb_tang.Location = new System.Drawing.Point(481, 192);
            this.rb_tang.Name = "rb_tang";
            this.rb_tang.Size = new System.Drawing.Size(75, 19);
            this.rb_tang.TabIndex = 13;
            this.rb_tang.TabStop = true;
            this.rb_tang.Text = "Tăng dần";
            this.rb_tang.UseVisualStyleBackColor = true;
            this.rb_tang.CheckedChanged += new System.EventHandler(this.rb_tang_CheckedChanged);
            // 
            // rb_giam
            // 
            this.rb_giam.AutoSize = true;
            this.rb_giam.Location = new System.Drawing.Point(480, 217);
            this.rb_giam.Name = "rb_giam";
            this.rb_giam.Size = new System.Drawing.Size(76, 19);
            this.rb_giam.TabIndex = 14;
            this.rb_giam.TabStop = true;
            this.rb_giam.Text = "Giảm dần";
            this.rb_giam.UseVisualStyleBackColor = true;
            this.rb_giam.CheckedChanged += new System.EventHandler(this.rb_giam_CheckedChanged);
            // 
            // dataGridView_hh
            // 
            this.dataGridView_hh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHH,
            this.TENHH,
            this.NGAYNHAPHANG,
            this.GIABAN,
            this.MAMH,
            this.MAQG});
            this.dataGridView_hh.Location = new System.Drawing.Point(12, 259);
            this.dataGridView_hh.Name = "dataGridView_hh";
            this.dataGridView_hh.Size = new System.Drawing.Size(655, 181);
            this.dataGridView_hh.TabIndex = 15;
            this.dataGridView_hh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hh_CellClick);
            this.dataGridView_hh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hh_CellContentClick);
            // 
            // MAHH
            // 
            this.MAHH.DataPropertyName = "MAHH";
            this.MAHH.HeaderText = "Mã Số Hàng Hóa";
            this.MAHH.Name = "MAHH";
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "Tên Hàng Hóa";
            this.TENHH.Name = "TENHH";
            // 
            // NGAYNHAPHANG
            // 
            this.NGAYNHAPHANG.DataPropertyName = "NGAYNHAPHANG";
            this.NGAYNHAPHANG.HeaderText = "Ngày Nhập hàng";
            this.NGAYNHAPHANG.Name = "NGAYNHAPHANG";
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.Name = "GIABAN";
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "Mặt hàng";
            this.MAMH.Name = "MAMH";
            // 
            // MAQG
            // 
            this.MAQG.DataPropertyName = "MAQG";
            this.MAQG.HeaderText = "Xuất Xứ";
            this.MAQG.Name = "MAQG";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(56, 217);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 36);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(153, 217);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 36);
            this.btn_capnhat.TabIndex = 17;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(249, 217);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 36);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Location = new System.Drawing.Point(347, 217);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(75, 36);
            this.btn_nhaplai.TabIndex = 19;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Xuất xứ:";
            // 
            // cb_mathang
            // 
            this.cb_mathang.FormattingEnabled = true;
            this.cb_mathang.Location = new System.Drawing.Point(481, 72);
            this.cb_mathang.Name = "cb_mathang";
            this.cb_mathang.Size = new System.Drawing.Size(152, 23);
            this.cb_mathang.TabIndex = 21;
            this.cb_mathang.SelectedIndexChanged += new System.EventHandler(this.cb_mathang_SelectedIndexChanged);
            // 
            // frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 481);
            this.Controls.Add(this.cb_mathang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView_hh);
            this.Controls.Add(this.rb_giam);
            this.Controls.Add(this.rb_tang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.dateTimePicker_ngaynhaphang);
            this.Controls.Add(this.txt_tenhang);
            this.Controls.Add(this.txt_mshh);
            this.Controls.Add(this.lb_xuatxu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frm_HangHoa";
            this.Text = "frm_HangHoa";
            this.Load += new System.EventHandler(this.frm_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_xuatxu;
        private System.Windows.Forms.TextBox txt_mshh;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaynhaphang;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_tang;
        private System.Windows.Forms.RadioButton rb_giam;
        private System.Windows.Forms.DataGridView dataGridView_hh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_mathang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAPHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQG;
    }
}