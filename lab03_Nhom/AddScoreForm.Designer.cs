namespace lab03_Nhom
{
    partial class AddScoreForm
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
            this.mahpLabel = new System.Windows.Forms.Label();
            this.mahpText = new System.Windows.Forms.TextBox();
            this.diemLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.diemText = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.mahpLabel);
            this.flowLayoutPanel1.Controls.Add(this.mahpText);
            this.flowLayoutPanel1.Controls.Add(this.diemLabel);
            this.flowLayoutPanel1.Controls.Add(this.diemText);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 385);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // mahpLabel
            // 
            this.mahpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mahpLabel.Location = new System.Drawing.Point(3, 0);
            this.mahpLabel.Name = "mahpLabel";
            this.mahpLabel.Size = new System.Drawing.Size(597, 23);
            this.mahpLabel.TabIndex = 0;
            this.mahpLabel.Text = "Mã học phần";
            // 
            // mahpText
            // 
            this.mahpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mahpText.Location = new System.Drawing.Point(3, 26);
            this.mahpText.Name = "mahpText";
            this.mahpText.Size = new System.Drawing.Size(597, 26);
            this.mahpText.TabIndex = 1;
            // 
            // diemLabel
            // 
            this.diemLabel.AutoSize = true;
            this.diemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemLabel.Location = new System.Drawing.Point(3, 55);
            this.diemLabel.Name = "diemLabel";
            this.diemLabel.Size = new System.Drawing.Size(46, 20);
            this.diemLabel.TabIndex = 2;
            this.diemLabel.Text = "Điểm";
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addButton.Location = new System.Drawing.Point(708, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 39);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // diemText
            // 
            this.diemText.DecimalPlaces = 2;
            this.diemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemText.Location = new System.Drawing.Point(3, 78);
            this.diemText.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.diemText.Name = "diemText";
            this.diemText.Size = new System.Drawing.Size(597, 26);
            this.diemText.TabIndex = 4;
            this.diemText.Tag = "0";
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddScoreForm";
            this.Text = "Màn hình thêm điểm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diemText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label mahpLabel;
        private System.Windows.Forms.TextBox mahpText;
        private System.Windows.Forms.Label diemLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown diemText;
    }
}