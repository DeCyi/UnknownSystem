﻿namespace UnknownSystem
{
    partial class LoginPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usernameField = new TextBox();
            passwordField = new TextBox();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 40);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // usernameField
            // 
            usernameField.Location = new Point(104, 32);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(100, 23);
            usernameField.TabIndex = 2;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(104, 72);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(100, 23);
            passwordField.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(120, 128);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginClick;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(loginButton);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPanel";
            Size = new Size(243, 177);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button loginButton;
    }
}
