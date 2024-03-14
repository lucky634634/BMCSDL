namespace lab03_Nhom
{
    partial class Form2
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
            this.lopListView = new System.Windows.Forms.ListView();
            this.maLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sidebar = new System.Windows.Forms.TableLayoutPanel();
            this.ViewButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.lopListView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sidebar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lopListView
            // 
            this.lopListView.AutoArrange = false;
            this.lopListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maLop,
            this.tenLop});
            this.lopListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lopListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lopListView.FullRowSelect = true;
            this.lopListView.HideSelection = false;
            this.lopListView.Location = new System.Drawing.Point(123, 3);
            this.lopListView.MultiSelect = false;
            this.lopListView.Name = "lopListView";
            this.lopListView.Size = new System.Drawing.Size(674, 444);
            this.lopListView.TabIndex = 0;
            this.lopListView.UseCompatibleStateImageBehavior = false;
            this.lopListView.View = System.Windows.Forms.View.Details;
            // 
            // maLop
            // 
            this.maLop.Text = "Mã lớp";
            this.maLop.Width = 100;
            // 
            // tenLop
            // 
            this.tenLop.Text = "Tên lớp";
            this.tenLop.Width = 386;
            // 
            // sidebar
            // 
            this.sidebar.ColumnCount = 1;
            this.sidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidebar.Controls.Add(this.ViewButton, 0, 0);
            this.sidebar.Controls.Add(this.exitButton, 0, 1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar.Location = new System.Drawing.Point(3, 3);
            this.sidebar.Name = "sidebar";
            this.sidebar.RowCount = 8;
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.sidebar.Size = new System.Drawing.Size(114, 444);
            this.sidebar.TabIndex = 1;
            // 
            // ViewButton
            // 
            this.ViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ViewButton.Location = new System.Drawing.Point(3, 3);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(108, 49);
            this.ViewButton.TabIndex = 0;
            this.ViewButton.Text = "Xem";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exitButton.Location = new System.Drawing.Point(3, 58);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 49);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Màn hình quản lý lớp học";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lopListView;
        private System.Windows.Forms.ColumnHeader maLop;
        private System.Windows.Forms.ColumnHeader tenLop;
        private System.Windows.Forms.TableLayoutPanel sidebar;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button exitButton;
    }
}