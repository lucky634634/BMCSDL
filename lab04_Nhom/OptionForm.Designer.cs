namespace lab04_Nhom
{
    partial class OptionForm
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
            this.ClassButton = new System.Windows.Forms.Button();
            this.nvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassButton
            // 
            this.ClassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassButton.AutoSize = true;
            this.ClassButton.Location = new System.Drawing.Point(326, 223);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(148, 53);
            this.ClassButton.TabIndex = 0;
            this.ClassButton.Text = "Màn hình quản lý lớp học";
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // nvButton
            // 
            this.nvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nvButton.AutoSize = true;
            this.nvButton.Location = new System.Drawing.Point(326, 103);
            this.nvButton.Name = "nvButton";
            this.nvButton.Size = new System.Drawing.Size(148, 66);
            this.nvButton.TabIndex = 1;
            this.nvButton.Text = "Màn hình quản lý nhân viên";
            this.nvButton.UseVisualStyleBackColor = true;
            this.nvButton.Click += new System.EventHandler(this.nvButton_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nvButton);
            this.Controls.Add(this.ClassButton);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button nvButton;
    }
}