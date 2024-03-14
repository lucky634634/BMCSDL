using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace lab03_CaNhan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            submitButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 20F);
            usernameLabel.Location = new Point(100, 100);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(192, 37);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Tên đăng nhập";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20F);
            passwordLabel.Location = new Point(100, 150);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(128, 37);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Mật khẩu";
            // 
            // usernameText
            // 
            usernameText.Font = new Font("Segoe UI", 20F);
            usernameText.Location = new Point(300, 100);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(400, 43);
            usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            passwordText.Font = new Font("Segoe UI", 20F);
            passwordText.Location = new Point(300, 150);
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = '*';
            passwordText.Size = new Size(400, 43);
            passwordText.TabIndex = 3;
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 12F);
            submitButton.Location = new Point(250, 300);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(100, 40);
            submitButton.TabIndex = 4;
            submitButton.Text = "Đăng nhập";
            submitButton.Click += SubmitButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F);
            exitButton.Location = new Point(450, 300);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 40);
            exitButton.TabIndex = 4;
            exitButton.Text = "Thoát";
            exitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitButton);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(exitButton);
            Name = "Form1";
            Text = "Màn Hình Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameText;
        private TextBox passwordText;
        private Button submitButton;
        private Button exitButton;
    }
}
