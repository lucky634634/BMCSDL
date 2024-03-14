namespace lab03_Nhom
{
    partial class SvForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SvListView = new System.Windows.Forms.ListView();
            this.MaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SvListView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.exitButton);
            this.flowLayoutPanel1.Controls.Add(this.editButton);
            this.flowLayoutPanel1.Controls.Add(this.refreshButton);
            this.flowLayoutPanel1.Controls.Add(this.scoreButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 385);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exitButton.Location = new System.Drawing.Point(694, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 59);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editButton.Location = new System.Drawing.Point(591, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 59);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Chỉnh sửa";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.refreshButton.Location = new System.Drawing.Point(498, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 59);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Làm mới";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.scoreButton.Location = new System.Drawing.Point(392, 3);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(100, 59);
            this.scoreButton.TabIndex = 1;
            this.scoreButton.Text = "Nhập điểm";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // SvListView
            // 
            this.SvListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.DiaChi});
            this.SvListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SvListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SvListView.FullRowSelect = true;
            this.SvListView.GridLines = true;
            this.SvListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SvListView.HideSelection = false;
            this.SvListView.Location = new System.Drawing.Point(3, 3);
            this.SvListView.MultiSelect = false;
            this.SvListView.Name = "SvListView";
            this.SvListView.Size = new System.Drawing.Size(794, 376);
            this.SvListView.TabIndex = 1;
            this.SvListView.UseCompatibleStateImageBehavior = false;
            this.SvListView.View = System.Windows.Forms.View.Details;
            // 
            // MaSV
            // 
            this.MaSV.Text = "Mã sinh viên";
            this.MaSV.Width = 77;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 233;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DisplayIndex = 3;
            this.NgaySinh.Text = "Ngày sinh";
            this.NgaySinh.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DisplayIndex = 2;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 353;
            // 
            // SvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SvForm";
            this.Text = "Màn hình quản lý sinh viên";
            this.Load += new System.EventHandler(this.SvForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListView SvListView;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button scoreButton;
    }
}