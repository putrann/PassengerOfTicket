﻿namespace GIAODIEN
{
    partial class frmQuanLyKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaQLKH = new System.Windows.Forms.Button();
            this.btnXoaQLKH = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvQuanLyKhachHang = new System.Windows.Forms.DataGridView();
            this.id_khachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTemp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1408, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ KHÁCH HÀNG";
            // 
            // btnSuaQLKH
            // 
            this.btnSuaQLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSuaQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaQLKH.ForeColor = System.Drawing.Color.White;
            this.btnSuaQLKH.Location = new System.Drawing.Point(1129, 194);
            this.btnSuaQLKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaQLKH.Name = "btnSuaQLKH";
            this.btnSuaQLKH.Size = new System.Drawing.Size(332, 47);
            this.btnSuaQLKH.TabIndex = 2;
            this.btnSuaQLKH.Text = "SỬA";
            this.btnSuaQLKH.UseVisualStyleBackColor = false;
            this.btnSuaQLKH.Click += new System.EventHandler(this.btnSuaQLKH_Click);
            // 
            // btnXoaQLKH
            // 
            this.btnXoaQLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaQLKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaQLKH.Location = new System.Drawing.Point(1129, 140);
            this.btnXoaQLKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaQLKH.Name = "btnXoaQLKH";
            this.btnXoaQLKH.Size = new System.Drawing.Size(332, 47);
            this.btnXoaQLKH.TabIndex = 3;
            this.btnXoaQLKH.Text = "XÓA";
            this.btnXoaQLKH.UseVisualStyleBackColor = false;
            this.btnXoaQLKH.Click += new System.EventHandler(this.btnXoaQLKH_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1129, 86);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "THÊM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvQuanLyKhachHang
            // 
            this.dgvQuanLyKhachHang.AllowUserToAddRows = false;
            this.dgvQuanLyKhachHang.AllowUserToDeleteRows = false;
            this.dgvQuanLyKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanLyKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_khachhang,
            this.hoten,
            this.dienthoai,
            this.email,
            this.loai});
            this.dgvQuanLyKhachHang.Location = new System.Drawing.Point(1, 68);
            this.dgvQuanLyKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuanLyKhachHang.Name = "dgvQuanLyKhachHang";
            this.dgvQuanLyKhachHang.ReadOnly = true;
            this.dgvQuanLyKhachHang.RowTemplate.Height = 24;
            this.dgvQuanLyKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyKhachHang.Size = new System.Drawing.Size(1087, 556);
            this.dgvQuanLyKhachHang.TabIndex = 5;
            this.dgvQuanLyKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKhachHang_CellClick);
            // 
            // id_khachhang
            // 
            this.id_khachhang.DataPropertyName = "id_khachhang";
            this.id_khachhang.HeaderText = "ID";
            this.id_khachhang.Name = "id_khachhang";
            this.id_khachhang.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện Thoại";
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại";
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(1105, 281);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 17);
            this.lblTemp.TabIndex = 5;
            this.lblTemp.Visible = false;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1483, 625);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.dgvQuanLyKhachHang);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXoaQLKH);
            this.Controls.Add(this.btnSuaQLKH);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            this.Click += new System.EventHandler(this.frmQuanLyKhachHang_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaQLKH;
        private System.Windows.Forms.Button btnXoaQLKH;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.DataGridView dgvQuanLyKhachHang;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
    }
}