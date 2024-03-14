namespace lab03_Nhom
{
    partial class EditScore
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
            this.diemText = new System.Windows.Forms.NumericUpDown();
            this.diemLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diemText)).BeginInit();
            this.SuspendLayout();
            // 
            // diemText
            // 
            this.diemText.DecimalPlaces = 2;
            this.diemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemText.Location = new System.Drawing.Point(186, 111);
            this.diemText.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.diemText.Name = "diemText";
            this.diemText.Size = new System.Drawing.Size(371, 26);
            this.diemText.TabIndex = 0;
            // 
            // diemLabel
            // 
            this.diemLabel.AutoSize = true;
            this.diemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diemLabel.Location = new System.Drawing.Point(186, 72);
            this.diemLabel.Name = "diemLabel";
            this.diemLabel.Size = new System.Drawing.Size(46, 20);
            this.diemLabel.TabIndex = 1;
            this.diemLabel.Text = "Điểm";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveButton.Location = new System.Drawing.Point(336, 323);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.diemLabel);
            this.Controls.Add(this.diemText);
            this.Name = "EditScore";
            this.Text = "EditScore";
            ((System.ComponentModel.ISupportInitialize)(this.diemText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown diemText;
        private System.Windows.Forms.Label diemLabel;
        private System.Windows.Forms.Button saveButton;
    }
}