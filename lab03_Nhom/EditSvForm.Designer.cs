namespace lab03_Nhom
{
    partial class EditSvForm
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
            this.hoTenLabel = new System.Windows.Forms.Label();
            this.hoTenText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.ngaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.diaChiText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hoTenLabel);
            this.flowLayoutPanel1.Controls.Add(this.hoTenText);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(634, 94);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hoTenLabel
            // 
            this.hoTenLabel.AutoSize = true;
            this.hoTenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoTenLabel.Location = new System.Drawing.Point(10, 10);
            this.hoTenLabel.Margin = new System.Windows.Forms.Padding(10);
            this.hoTenLabel.Name = "hoTenLabel";
            this.hoTenLabel.Size = new System.Drawing.Size(77, 20);
            this.hoTenLabel.TabIndex = 0;
            this.hoTenLabel.Text = "Họ và tên";
            // 
            // hoTenText
            // 
            this.hoTenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoTenText.Location = new System.Drawing.Point(3, 43);
            this.hoTenText.Name = "hoTenText";
            this.hoTenText.Size = new System.Drawing.Size(631, 26);
            this.hoTenText.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ngaySinhLabel);
            this.flowLayoutPanel2.Controls.Add(this.ngaySinhPicker);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(83, 153);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(634, 94);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaySinhLabel.Location = new System.Drawing.Point(10, 10);
            this.ngaySinhLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(81, 20);
            this.ngaySinhLabel.TabIndex = 2;
            this.ngaySinhLabel.Text = "Ngày Sinh";
            // 
            // ngaySinhPicker
            // 
            this.ngaySinhPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ngaySinhPicker.CustomFormat = "ddd dd MMM yyyy";
            this.ngaySinhPicker.Location = new System.Drawing.Point(0, 40);
            this.ngaySinhPicker.Margin = new System.Windows.Forms.Padding(0);
            this.ngaySinhPicker.Name = "ngaySinhPicker";
            this.ngaySinhPicker.Size = new System.Drawing.Size(631, 20);
            this.ngaySinhPicker.TabIndex = 3;
            this.ngaySinhPicker.Value = new System.DateTime(2024, 3, 13, 17, 16, 58, 0);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.diaChiLabel);
            this.flowLayoutPanel3.Controls.Add(this.diaChiText);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(83, 253);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(634, 94);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiLabel.Location = new System.Drawing.Point(10, 10);
            this.diaChiLabel.Margin = new System.Windows.Forms.Padding(10);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(57, 20);
            this.diaChiLabel.TabIndex = 2;
            this.diaChiLabel.Text = "Địa chỉ";
            // 
            // diaChiText
            // 
            this.diaChiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diaChiText.Location = new System.Drawing.Point(3, 43);
            this.diaChiText.Name = "diaChiText";
            this.diaChiText.Size = new System.Drawing.Size(631, 26);
            this.diaChiText.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveButton.Location = new System.Drawing.Point(83, 353);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 50);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditSvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditSvForm";
            this.Text = "Màn hình chỉnh sửa thông tin sinh viên";
            this.Load += new System.EventHandler(this.EditSvForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label hoTenLabel;
        private System.Windows.Forms.TextBox hoTenText;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.TextBox diaChiText;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DateTimePicker ngaySinhPicker;
        private System.Windows.Forms.Button saveButton;
    }
}