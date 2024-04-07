namespace lab04_Nhom
{
    partial class NVForm
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
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.nvDataList = new System.Windows.Forms.DataGridView();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mkText = new System.Windows.Forms.TextBox();
            this.tendnText = new System.Windows.Forms.TextBox();
            this.luongText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.hotenText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manvText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.themButton = new System.Windows.Forms.Button();
            this.xoaButton = new System.Windows.Forms.Button();
            this.suaButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.lmButton = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvDataList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayout.Controls.Add(this.title, 0, 0);
            this.mainLayout.Controls.Add(this.nvDataList, 0, 2);
            this.mainLayout.Controls.Add(this.groupBox1, 0, 1);
            this.mainLayout.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 4;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.29792F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6224F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.079673F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(1184, 560);
            this.mainLayout.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1178, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Danh Mục Nhân Viên";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nvDataList
            // 
            this.nvDataList.AllowUserToAddRows = false;
            this.nvDataList.AllowUserToDeleteRows = false;
            this.nvDataList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nvDataList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.nvDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.hoten,
            this.email,
            this.luong});
            this.nvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvDataList.Location = new System.Drawing.Point(3, 252);
            this.nvDataList.MultiSelect = false;
            this.nvDataList.Name = "nvDataList";
            this.nvDataList.ReadOnly = true;
            this.nvDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nvDataList.ShowCellToolTips = false;
            this.nvDataList.ShowEditingIcon = false;
            this.nvDataList.ShowRowErrors = false;
            this.nvDataList.Size = new System.Drawing.Size(1178, 267);
            this.nvDataList.TabIndex = 2;
            this.nvDataList.TabStop = false;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nv";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // luong
            // 
            this.luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.luong.HeaderText = "lương";
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.mkText, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tendnText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.luongText, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hotenText, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.manvText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 177);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mkText
            // 
            this.mkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mkText.Enabled = false;
            this.mkText.Location = new System.Drawing.Point(711, 121);
            this.mkText.Name = "mkText";
            this.mkText.Size = new System.Drawing.Size(467, 21);
            this.mkText.TabIndex = 6;
            this.mkText.UseSystemPasswordChar = true;
            this.mkText.WordWrap = false;
            // 
            // tendnText
            // 
            this.tendnText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tendnText.Enabled = false;
            this.tendnText.Location = new System.Drawing.Point(121, 121);
            this.tendnText.Name = "tendnText";
            this.tendnText.Size = new System.Drawing.Size(466, 21);
            this.tendnText.TabIndex = 5;
            this.tendnText.WordWrap = false;
            // 
            // luongText
            // 
            this.luongText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.luongText.Enabled = false;
            this.luongText.Location = new System.Drawing.Point(711, 62);
            this.luongText.Name = "luongText";
            this.luongText.Size = new System.Drawing.Size(467, 21);
            this.luongText.TabIndex = 4;
            this.luongText.WordWrap = false;
            // 
            // emailText
            // 
            this.emailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailText.Enabled = false;
            this.emailText.Location = new System.Drawing.Point(121, 62);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(466, 21);
            this.emailText.TabIndex = 3;
            this.emailText.WordWrap = false;
            // 
            // hotenText
            // 
            this.hotenText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotenText.Enabled = false;
            this.hotenText.Location = new System.Drawing.Point(711, 3);
            this.hotenText.Name = "hotenText";
            this.hotenText.Size = new System.Drawing.Size(467, 21);
            this.hotenText.TabIndex = 2;
            this.hotenText.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // manvText
            // 
            this.manvText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manvText.Enabled = false;
            this.manvText.Location = new System.Drawing.Point(121, 3);
            this.manvText.Name = "manvText";
            this.manvText.Size = new System.Drawing.Size(466, 21);
            this.manvText.TabIndex = 1;
            this.manvText.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(5, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(595, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(595, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 54);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật khẩu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.themButton);
            this.flowLayoutPanel1.Controls.Add(this.xoaButton);
            this.flowLayoutPanel1.Controls.Add(this.suaButton);
            this.flowLayoutPanel1.Controls.Add(this.luuButton);
            this.flowLayoutPanel1.Controls.Add(this.lmButton);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(284, 525);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 32);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.TabStop = true;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // themButton
            // 
            this.themButton.Location = new System.Drawing.Point(40, 3);
            this.themButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(75, 23);
            this.themButton.TabIndex = 0;
            this.themButton.Text = "Thêm";
            this.themButton.UseVisualStyleBackColor = true;
            this.themButton.Click += new System.EventHandler(this.themButton_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.Location = new System.Drawing.Point(155, 3);
            this.xoaButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(75, 23);
            this.xoaButton.TabIndex = 1;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = true;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // suaButton
            // 
            this.suaButton.Location = new System.Drawing.Point(270, 3);
            this.suaButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(75, 23);
            this.suaButton.TabIndex = 2;
            this.suaButton.Text = "Sửa";
            this.suaButton.UseVisualStyleBackColor = true;
            this.suaButton.Click += new System.EventHandler(this.suaButton_Click);
            // 
            // luuButton
            // 
            this.luuButton.Location = new System.Drawing.Point(385, 3);
            this.luuButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(75, 23);
            this.luuButton.TabIndex = 3;
            this.luuButton.Text = "Ghi/Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            this.luuButton.Click += new System.EventHandler(this.luuButton_Click);
            // 
            // lmButton
            // 
            this.lmButton.Location = new System.Drawing.Point(500, 3);
            this.lmButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.lmButton.Name = "lmButton";
            this.lmButton.Size = new System.Drawing.Size(75, 23);
            this.lmButton.TabIndex = 4;
            this.lmButton.Text = "Làm mới";
            this.lmButton.UseVisualStyleBackColor = true;
            this.lmButton.Click += new System.EventHandler(this.lmButton_Click);
            // 
            // NVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 560);
            this.Controls.Add(this.mainLayout);
            this.Name = "NVForm";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.NVForm_Load);
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvDataList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView nvDataList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.Button suaButton;
        private System.Windows.Forms.Button luuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox manvText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mkText;
        private System.Windows.Forms.TextBox tendnText;
        private System.Windows.Forms.TextBox luongText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox hotenText;
        private System.Windows.Forms.Button lmButton;
    }
}