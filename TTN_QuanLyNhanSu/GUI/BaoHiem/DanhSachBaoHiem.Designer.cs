﻿namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    partial class DanhSachBaoHiem
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
            this.components = new System.ComponentModel.Container();
            this.baoHiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTN_QLNhanSuDataSet = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSet();
            this.baoHiemTableAdapter = new TTN_QuanLyNhanSu.TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonQuayLai = new System.Windows.Forms.Button();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.dataGridViewdsBaoHiem = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemXHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBaoHiemYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTimKiem = new System.Windows.Forms.ComboBox();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.buttonChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baoHiemBindingSource
            // 
            this.baoHiemBindingSource.DataMember = "BaoHiem";
            this.baoHiemBindingSource.DataSource = this.tTN_QLNhanSuDataSet;
            // 
            // tTN_QLNhanSuDataSet
            // 
            this.tTN_QLNhanSuDataSet.DataSetName = "TTN_QLNhanSuDataSet";
            this.tTN_QLNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoHiemTableAdapter
            // 
            this.baoHiemTableAdapter.ClearBeforeFill = true;
            // 
            // buttonThem
            // 
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(25, 23);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(120, 37);
            this.buttonThem.TabIndex = 20;
            this.buttonThem.Text = "+ Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonQuayLai
            // 
            this.buttonQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuayLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuayLai.Location = new System.Drawing.Point(893, 108);
            this.buttonQuayLai.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuayLai.Name = "buttonQuayLai";
            this.buttonQuayLai.Size = new System.Drawing.Size(120, 37);
            this.buttonQuayLai.TabIndex = 21;
            this.buttonQuayLai.Text = "Quay Lại";
            this.buttonQuayLai.UseVisualStyleBackColor = true;
            this.buttonQuayLai.Click += new System.EventHandler(this.buttonQuayLai_Click);
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBoxTimKiem.Location = new System.Drawing.Point(643, 27);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(211, 29);
            this.textBoxTimKiem.TabIndex = 25;
            // 
            // dataGridViewdsBaoHiem
            // 
            this.dataGridViewdsBaoHiem.AutoGenerateColumns = false;
            this.dataGridViewdsBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdsBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.soBaoHiemXHDataGridViewTextBoxColumn,
            this.soBaoHiemYTDataGridViewTextBoxColumn,
            this.noiCapDataGridViewTextBoxColumn,
            this.ngayCapDataGridViewTextBoxColumn});
            this.dataGridViewdsBaoHiem.DataSource = this.baoHiemBindingSource;
            this.dataGridViewdsBaoHiem.Location = new System.Drawing.Point(4, 159);
            this.dataGridViewdsBaoHiem.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewdsBaoHiem.Name = "dataGridViewdsBaoHiem";
            this.dataGridViewdsBaoHiem.RowHeadersWidth = 51;
            this.dataGridViewdsBaoHiem.Size = new System.Drawing.Size(1055, 484);
            this.dataGridViewdsBaoHiem.TabIndex = 26;
            this.dataGridViewdsBaoHiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdsBaoHiem_CellClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "Họ Tên NV";
            this.hoTenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.Width = 160;
            // 
            // soBaoHiemXHDataGridViewTextBoxColumn
            // 
            this.soBaoHiemXHDataGridViewTextBoxColumn.DataPropertyName = "SoBaoHiemXH";
            this.soBaoHiemXHDataGridViewTextBoxColumn.HeaderText = "Số Bảo Hiểm XH";
            this.soBaoHiemXHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soBaoHiemXHDataGridViewTextBoxColumn.Name = "soBaoHiemXHDataGridViewTextBoxColumn";
            this.soBaoHiemXHDataGridViewTextBoxColumn.Width = 110;
            // 
            // soBaoHiemYTDataGridViewTextBoxColumn
            // 
            this.soBaoHiemYTDataGridViewTextBoxColumn.DataPropertyName = "SoBaoHiemYT";
            this.soBaoHiemYTDataGridViewTextBoxColumn.HeaderText = "Số Bảo Hiểm YT";
            this.soBaoHiemYTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soBaoHiemYTDataGridViewTextBoxColumn.Name = "soBaoHiemYTDataGridViewTextBoxColumn";
            this.soBaoHiemYTDataGridViewTextBoxColumn.Width = 110;
            // 
            // noiCapDataGridViewTextBoxColumn
            // 
            this.noiCapDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noiCapDataGridViewTextBoxColumn.DataPropertyName = "NoiCap";
            this.noiCapDataGridViewTextBoxColumn.HeaderText = "Nơi Cấp";
            this.noiCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noiCapDataGridViewTextBoxColumn.Name = "noiCapDataGridViewTextBoxColumn";
            // 
            // ngayCapDataGridViewTextBoxColumn
            // 
            this.ngayCapDataGridViewTextBoxColumn.DataPropertyName = "NgayCap";
            this.ngayCapDataGridViewTextBoxColumn.HeaderText = "Ngày Cấp";
            this.ngayCapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapDataGridViewTextBoxColumn.Name = "ngayCapDataGridViewTextBoxColumn";
            this.ngayCapDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxTong);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridViewdsBaoHiem);
            this.panel1.Controls.Add(this.buttonQuayLai);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 647);
            this.panel1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label10.Location = new System.Drawing.Point(11, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tổng";
            // 
            // textBoxTong
            // 
            this.textBoxTong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTong.Location = new System.Drawing.Point(71, 116);
            this.textBoxTong.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTong.Name = "textBoxTong";
            this.textBoxTong.Size = new System.Drawing.Size(99, 29);
            this.textBoxTong.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonTimKiem);
            this.groupBox1.Controls.Add(this.buttonChiTiet);
            this.groupBox1.Controls.Add(this.textBoxTimKiem);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(996, 79);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxTimKiem
            // 
            this.comboBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxTimKiem.FormattingEnabled = true;
            this.comboBoxTimKiem.Items.AddRange(new object[] {
            "Mã Nhân Viên",
            "Tên Nhân Viên"});
            this.comboBoxTimKiem.Location = new System.Drawing.Point(411, 27);
            this.comboBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTimKiem.Name = "comboBoxTimKiem";
            this.comboBoxTimKiem.Size = new System.Drawing.Size(213, 30);
            this.comboBoxTimKiem.TabIndex = 26;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTimKiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(868, 23);
            this.buttonTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(120, 37);
            this.buttonTimKiem.TabIndex = 22;
            this.buttonTimKiem.Text = "Tìm Kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // buttonChiTiet
            // 
            this.buttonChiTiet.Enabled = false;
            this.buttonChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChiTiet.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChiTiet.Location = new System.Drawing.Point(160, 23);
            this.buttonChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChiTiet.Name = "buttonChiTiet";
            this.buttonChiTiet.Size = new System.Drawing.Size(120, 37);
            this.buttonChiTiet.TabIndex = 21;
            this.buttonChiTiet.Text = "Chi Tiết";
            this.buttonChiTiet.UseVisualStyleBackColor = true;
            this.buttonChiTiet.Click += new System.EventHandler(this.buttonChiTiet_Click);
            // 
            // DanhSachBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachBaoHiem";
            this.Load += new System.EventHandler(this.DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoHiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTN_QLNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsBaoHiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TTN_QLNhanSuDataSet tTN_QLNhanSuDataSet;
        private System.Windows.Forms.BindingSource baoHiemBindingSource;
        private TTN_QLNhanSuDataSetTableAdapters.BaoHiemTableAdapter baoHiemTableAdapter;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonQuayLai;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.DataGridView dataGridViewdsBaoHiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Button buttonChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemXHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBaoHiemYTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxTong;
    }
}