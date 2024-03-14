namespace lab03_Nhom
{
    partial class ScoreList
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
            this.scoreListView = new System.Windows.Forms.ListView();
            this.MaHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenHP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.scoreListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // scoreListView
            // 
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHP,
            this.TenHP,
            this.Diem});
            this.scoreListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.scoreListView.FullRowSelect = true;
            this.scoreListView.GridLines = true;
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(3, 3);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(794, 376);
            this.scoreListView.TabIndex = 0;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            // 
            // MaHP
            // 
            this.MaHP.Text = "Mã học phần";
            this.MaHP.Width = 86;
            // 
            // TenHP
            // 
            this.TenHP.Text = "Tên học phần";
            this.TenHP.Width = 237;
            // 
            // Diem
            // 
            this.Diem.Text = "Điểm";
            this.Diem.Width = 203;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteButton);
            this.flowLayoutPanel1.Controls.Add(this.editButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 387);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(790, 58);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addButton.Location = new System.Drawing.Point(684, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 55);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteButton.Location = new System.Drawing.Point(575, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 55);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editButton.Location = new System.Drawing.Point(466, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 55);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Sửa";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScoreList";
            this.Text = "Điểm thi";
            this.Load += new System.EventHandler(this.ScoreList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader MaHP;
        private System.Windows.Forms.ColumnHeader TenHP;
        private System.Windows.Forms.ColumnHeader Diem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}